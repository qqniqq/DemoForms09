using DemoLib.Models;
using MySql.Data.MySqlClient;

namespace DemoLib.Repositories
{
    public class UserRepository
        : BaseRepository
    {
        public User GetByCredentials(
            string login,
            string password)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"SELECT
                    u.*,
                    r.name RoleName
                  FROM users u
                  INNER JOIN roles r
                        ON r.id = u.role_id
                  WHERE u.login=@login
                  AND u.password=@password";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@login",
                    login);

                command.Parameters.AddWithValue(
                    "@password",
                    password);

                using (var reader =
                    command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id =
                                reader.GetInt32("id"),

                            RoleId =
                                reader.GetInt32("role_id"),

                            FullName =
                                reader["full_name"].ToString(),

                            Login =
                                reader["login"].ToString(),

                            Password =
                                reader["password"].ToString(),

                            Role =
                                new Role
                                {
                                    Name =
                                    reader["RoleName"].ToString()
                                }
                        };
                    }
                }
            }

            return null;
        }
    }
}