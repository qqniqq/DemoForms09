using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class OrderItemRepository
        : BaseRepository
    {
        public List<OrderItem> GetByOrderId(
            int orderId)
        {
            List<OrderItem> items =
                new List<OrderItem>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"SELECT *
                  FROM order_items
                  WHERE order_id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@id",
                    orderId);

                using (var reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(
                            new OrderItem
                            {
                                Id =
                                    reader.GetInt32("id"),

                                OrderId =
                                    reader.GetInt32("order_id"),

                                ProductId =
                                    reader.GetInt32("product_id"),

                                Quantity =
                                    reader.GetInt32("quantity")
                            });
                    }
                }
            }

            return items;
        }

        public void Add(OrderItem item)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO order_items
                (
                    order_id,
                    product_id,
                    quantity
                )
                VALUES
                (
                    @order,
                    @product,
                    @quantity
                )";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@order",
                    item.OrderId);

                command.Parameters.AddWithValue(
                    "@product",
                    item.ProductId);

                command.Parameters.AddWithValue(
                    "@quantity",
                    item.Quantity);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteByOrderId(
            int orderId)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"DELETE FROM order_items
                  WHERE order_id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue(
                    "@id",
                    orderId);

                command.ExecuteNonQuery();
            }
        }
    }
}