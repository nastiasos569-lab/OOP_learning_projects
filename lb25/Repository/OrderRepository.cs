using lb25.Data;
using lb25.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace lb25.Repository
{
    public class OrderRepository
    {
        private DbConnection db = new DbConnection();
        public void Add(Order order)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Orders 
                (client_id, service_id, date, quantity, total) 
                VALUES (@client, @service, @date, @qty, @total)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@client", order.ClientId);
                cmd.Parameters.AddWithValue("@service", order.ServiceId);
                cmd.Parameters.AddWithValue("@date", order.Date);
                cmd.Parameters.AddWithValue("@qty", order.Quantity);
                cmd.Parameters.AddWithValue("@total", order.Total);

                cmd.ExecuteNonQuery();
            }
        }
        public List<Order> GetAll()
        {
            List<Order> list = new List<Order>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT o.*, c.name, s.service_name
                FROM Orders o
                JOIN Clients c ON o.client_id = c.client_id
                JOIN Services s ON o.service_id = s.service_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Order
                    {
                        Id = reader.GetInt32("order_id"),
                        ClientId = reader.GetInt32("client_id"),
                        ServiceId = reader.GetInt32("service_id"),
                        Date = reader.GetDateTime("date"),
                        Quantity = reader.GetInt32("quantity"),
                        Total = reader.GetDecimal("total"),
                        ClientName = reader.GetString("name"),
                        ServiceName = reader.GetString("service_name")
                    });
                }
            }

            return list;
        }

        public void Update(Order order)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Orders 
                SET client_id=@client, service_id=@service, 
                    date=@date, quantity=@qty, total=@total
                WHERE order_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", order.Id);
                cmd.Parameters.AddWithValue("@client", order.ClientId);
                cmd.Parameters.AddWithValue("@service", order.ServiceId);
                cmd.Parameters.AddWithValue("@date", order.Date);
                cmd.Parameters.AddWithValue("@qty", order.Quantity);
                cmd.Parameters.AddWithValue("@total", order.Total);

                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Orders WHERE order_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}