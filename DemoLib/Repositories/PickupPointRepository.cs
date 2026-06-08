using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class PickupPointRepository
        : BaseRepository
    {
        public List<PickupPoint> GetAll()
        {
            List<PickupPoint> list =
                new List<PickupPoint>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM pickup_points";

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
                            new PickupPoint
                            {
                                Id =
                                    reader.GetInt32("id"),

                                Address =
                                    reader["address"]
                                    .ToString()
                            });
                    }
                }
            }

            return list;
        }
    }
}