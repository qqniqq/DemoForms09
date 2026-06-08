using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class OrderRepository
        : BaseRepository
    {
        public List<Order> GetAll()
        {
            List<Order> orders =
                new List<Order>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"SELECT
                    o.*,
                    pp.address,
                    st.name StatusName

                  FROM orders o

                  INNER JOIN pickup_points pp
                        ON pp.id=o.pickup_point_id

                  INNER JOIN order_statuses st
                        ON st.id=o.status_id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                using (var reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(
                            new Order
                            {
                                Id =
                                    reader.GetInt32("id"),

                                OrderNumber =
                                    reader.GetInt32("order_number"),

                                ClientName =
                                    reader["client_name"].ToString(),

                                ReceiveCode =
                                    reader["receive_code"].ToString(),

                                OrderDate =
                                    reader.GetDateTime("order_date"),

                                DeliveryDate =
                                    reader.GetDateTime("delivery_date"),

                                PickupPoint =
                                    new PickupPoint
                                    {
                                        Address =
                                        reader["address"].ToString()
                                    },

                                Status =
                                    new OrderStatus
                                    {
                                        Name =
                                        reader["StatusName"].ToString()
                                    }
                            });
                    }
                }
            }

            return orders;
        }
        public void Add(Order order)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO orders
                (
                    order_number,
                    order_date,
                    delivery_date,
                    pickup_point_id,
                    client_name,
                    receive_code,
                    status_id
                )
                VALUES
                (
                    @number,
                    @orderDate,
                    @deliveryDate,
                    @pickup,
                    @client,
                    @code,
                    @status
                )";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue("@number", order.OrderNumber);
                command.Parameters.AddWithValue("@orderDate", order.OrderDate);
                command.Parameters.AddWithValue("@deliveryDate", order.DeliveryDate);
                command.Parameters.AddWithValue("@pickup", order.PickupPointId);
                command.Parameters.AddWithValue("@client", order.ClientName);
                command.Parameters.AddWithValue("@code", order.ReceiveCode);
                command.Parameters.AddWithValue("@status", order.StatusId);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Order order)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"UPDATE orders
                  SET
                    order_number=@number,
                    order_date=@orderDate,
                    delivery_date=@deliveryDate,
                    pickup_point_id=@pickup,
                    client_name=@client,
                    receive_code=@code,
                    status_id=@status
                  WHERE id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue("@id", order.Id);
                command.Parameters.AddWithValue("@number", order.OrderNumber);
                command.Parameters.AddWithValue("@orderDate", order.OrderDate);
                command.Parameters.AddWithValue("@deliveryDate", order.DeliveryDate);
                command.Parameters.AddWithValue("@pickup", order.PickupPointId);
                command.Parameters.AddWithValue("@client", order.ClientName);
                command.Parameters.AddWithValue("@code", order.ReceiveCode);
                command.Parameters.AddWithValue("@status", order.StatusId);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "DELETE FROM orders WHERE id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@id",
                    id);

                command.ExecuteNonQuery();
            }
        }
        public Order GetById(int id)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM orders WHERE id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@id",
                    id);

                using (var reader =
                    command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Order
                        {
                            Id =
                                reader.GetInt32("id"),

                            OrderNumber =
                                reader.GetInt32(
                                    "order_number"),

                            ClientName =
                                reader["client_name"]
                                .ToString(),

                            ReceiveCode =
                                reader["receive_code"]
                                .ToString(),

                            OrderDate =
                                reader.GetDateTime(
                                    "order_date"),

                            DeliveryDate =
                                reader.GetDateTime(
                                    "delivery_date"),

                            PickupPointId =
                                reader.GetInt32(
                                    "pickup_point_id"),

                            StatusId =
                                reader.GetInt32(
                                    "status_id")
                        };
                    }
                }
            }

            return null;
        }
    }
}