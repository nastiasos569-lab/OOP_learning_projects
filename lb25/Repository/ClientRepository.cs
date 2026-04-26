using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lb25.Models;
using MySql.Data.MySqlClient;
using lb25.Data;

namespace lb25.Repository
{
  
    public class ClientRepository
    {
        private DbConnection db = new DbConnection();

        public void Add(Models.Client client)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Clients (name, phone) VALUES (@name, @phone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@phone", client.Phone);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Models.Client> GetAll()
        {
            List<Models.Client> list = new List<Models.Client>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Clients";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Models.Client
                    {
                        Id = reader.GetInt32("client_id"),
                        Name = reader.GetString("name"),
                        Phone = reader.GetString("phone")
                    });
                }
            }

            return list;
        }

        public List<Models.Client> Search(string name)
        {
            List<Models.Client> list = new List<Models.Client>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Clients WHERE name LIKE @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Models.Client
                    {
                        Id = reader.GetInt32("client_id"),
                        Name = reader.GetString("name"),
                        Phone = reader.GetString("phone")
                    });
                }
            }

            return list;
        }
        public void Update(Client client)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "UPDATE Clients SET name=@name, phone=@phone WHERE client_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@phone", client.Phone);

                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Clients WHERE client_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
