using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class OrderStatusRepository
        : BaseRepository
    {
        public List<OrderStatus> GetAll()
        {
            List<OrderStatus> list =
                new List<OrderStatus>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM order_statuses";

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
                            new OrderStatus
                            {
                                Id =
                                    reader.GetInt32("id"),

                                Name =
                                    reader["name"]
                                    .ToString()
                            });
                    }
                }
            }

            return list;
        }
    }
}