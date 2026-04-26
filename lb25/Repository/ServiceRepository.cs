using lb25.Data;
using lb25.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace lb25.Repository
{
    public class ServiceRepository
    {
        private DbConnection db = new DbConnection();

        public void Add(Service service)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Services (service_name, price) VALUES (@name, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", service.ServiceName);
                cmd.Parameters.AddWithValue("@price", service.Price);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Service> GetAll()
        {
            List<Service> list = new List<Service>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Services";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Service
                    {
                        Id = reader.GetInt32("service_id"),
                        ServiceName = reader.GetString("service_name"),
                        Price = reader.GetDecimal("price")
                    });
                }
            }

            return list;
        }

        public void Update(Service service)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Services SET service_name=@name, price=@price WHERE service_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", service.Id);
                cmd.Parameters.AddWithValue("@name", service.ServiceName);
                cmd.Parameters.AddWithValue("@price", service.Price);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Services WHERE service_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Service> Search(string name)
        {
            List<Service> list = new List<Service>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Services WHERE service_name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Service
                    {
                        Id = reader.GetInt32("service_id"),
                        ServiceName = reader.GetString("service_name"),
                        Price = reader.GetDecimal("price")
                    });
                }
            }

            return list;
        }
    }
}