using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.Common;

namespace DAL.Repositories
{
    public class DBConnection
    {
        private readonly string connectionString;

        public DBConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


    }
}
