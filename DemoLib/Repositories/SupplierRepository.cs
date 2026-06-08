using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class SupplierRepository
        : BaseRepository
    {
        public List<Supplier> GetAll()
        {
            List<Supplier> list =
                new List<Supplier>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM suppliers";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                using (var reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(
                            new Supplier
                            {
                                Id =
                                    reader.GetInt32("id"),

                                Name =
                                    reader["name"].ToString()
                            });
                    }
                }
            }

            return list;
        }
    }
}