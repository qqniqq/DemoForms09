using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class ManufacturerRepository
        : BaseRepository
    {
        public List<Manufacturer> GetAll()
        {
            List<Manufacturer> list =
                new List<Manufacturer>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM manufacturers";

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
                            new Manufacturer
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