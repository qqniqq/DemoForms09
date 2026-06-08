using DemoLib.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DemoLib.Repositories
{
    public class ProductRepository
        : BaseRepository
    {
        public List<Product> GetAll()
        {
            List<Product> products =
                new List<Product>();

            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"SELECT
                    p.*,
                    c.name CategoryName,
                    m.name ManufacturerName,
                    s.name SupplierName

                  FROM products p

                  INNER JOIN categories c
                    ON c.id = p.category_id

                  INNER JOIN manufacturers m
                    ON m.id = p.manufacturer_id

                  INNER JOIN suppliers s
                    ON s.id = p.supplier_id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                using (var reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                Id =
                                    reader.GetInt32("id"),

                                Article =
                                    reader["article"].ToString(),

                                Name =
                                    reader["name"].ToString(),

                                Unit =
                                    reader["unit"].ToString(),

                                Price =
                                    reader.GetDecimal("price"),

                                Discount =
                                    reader.GetDecimal("discount"),

                                StockQuantity =
                                    reader.GetInt32("stock_quantity"),

                                Description =
                                    reader["description"].ToString(),

                                ImagePath =
                                    reader["image_path"].ToString(),

                                Category =
                                    new Category
                                    {
                                        Name =
                                        reader["CategoryName"].ToString()
                                    },

                                Manufacturer =
                                    new Manufacturer
                                    {
                                        Name =
                                        reader["ManufacturerName"].ToString()
                                    },

                                Supplier =
                                    new Supplier
                                    {
                                        Name =
                                        reader["SupplierName"].ToString()
                                    }
                            });
                    }
                }
            }

            return products;
        }
        public void Add(Product product)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"INSERT INTO products
                (
                    article,
                    name,
                    unit,
                    price,
                    supplier_id,
                    manufacturer_id,
                    category_id,
                    discount,
                    stock_quantity,
                    description,
                    image_path
                )
                VALUES
                (
                    @article,
                    @name,
                    @unit,
                    @price,
                    @supplier,
                    @manufacturer,
                    @category,
                    @discount,
                    @stock,
                    @description,
                    @image
                )";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue("@article", product.Article);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@unit", product.Unit);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@supplier", product.SupplierId);
                command.Parameters.AddWithValue("@manufacturer", product.ManufacturerId);
                command.Parameters.AddWithValue("@category", product.CategoryId);
                command.Parameters.AddWithValue("@discount", product.Discount);
                command.Parameters.AddWithValue("@stock", product.StockQuantity);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@image", product.ImagePath);

                command.ExecuteNonQuery();
            }
        }
        public void Update(Product product)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"UPDATE products
                  SET

                  article=@article,
                  name=@name,
                  unit=@unit,
                  price=@price,

                  supplier_id=@supplier,
                  manufacturer_id=@manufacturer,
                  category_id=@category,

                  discount=@discount,
                  stock_quantity=@stock,

                  description=@description,
                  image_path=@image

                  WHERE id=@id";

                MySqlCommand command =
                    new MySqlCommand(
                        query,
                        connection);

                command.Parameters.AddWithValue("@id", product.Id);

                command.Parameters.AddWithValue("@article", product.Article);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@unit", product.Unit);
                command.Parameters.AddWithValue("@price", product.Price);

                command.Parameters.AddWithValue("@supplier", product.SupplierId);
                command.Parameters.AddWithValue("@manufacturer", product.ManufacturerId);
                command.Parameters.AddWithValue("@category", product.CategoryId);

                command.Parameters.AddWithValue("@discount", product.Discount);
                command.Parameters.AddWithValue("@stock", product.StockQuantity);

                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@image", product.ImagePath);

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
                    "DELETE FROM products WHERE id=@id";

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
        public Product GetById(int id)
        {
            using (var connection =
                GetConnection())
            {
                connection.Open();

                string query =
                @"SELECT *
          FROM products
          WHERE id=@id";

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
                        return new Product
                        {
                            Id =
                                reader.GetInt32("id"),

                            Article =
                                reader["article"].ToString(),

                            Name =
                                reader["name"].ToString(),

                            Unit =
                                reader["unit"].ToString(),

                            Price =
                                reader.GetDecimal("price"),

                            SupplierId =
                                reader.GetInt32("supplier_id"),

                            ManufacturerId =
                                reader.GetInt32("manufacturer_id"),

                            CategoryId =
                                reader.GetInt32("category_id"),

                            Discount =
                                reader.GetDecimal("discount"),

                            StockQuantity =
                                reader.GetInt32("stock_quantity"),

                            Description =
                                reader["description"].ToString(),

                            ImagePath =
                                reader["image_path"].ToString()
                        };
                    }
                }
            }

            return null;
        }
    }
}