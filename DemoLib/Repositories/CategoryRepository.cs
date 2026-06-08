using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class CategoryRepository
        : BaseRepository
    {
        public List<Category> GetAll()
        {
            List<Category> list =
                new List<Category>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM categories";

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
                            new Category
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