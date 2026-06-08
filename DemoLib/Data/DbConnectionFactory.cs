using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace DemoLib.Data
{
    public static class DbConnectionFactory
    {
        public static MySqlConnection Create()
        {
            string connectionString =
                ConfigurationManager
                .ConnectionStrings["MySqlConnection"]
                .ConnectionString;

            return new MySqlConnection(
                connectionString);
        }
    }
}