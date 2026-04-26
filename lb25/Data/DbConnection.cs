using System;
using MySql.Data.MySqlClient;

namespace lb25.Data
{
    public class DbConnection
    {
        private string connectionString =
            "server=localhost;database=laundry_db;uid=root;pwd=Postman;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}