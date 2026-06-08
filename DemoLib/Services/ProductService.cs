using DemoLib.Models;
using DemoLib.Repositories;
using System.Collections.Generic;

namespace DemoLib.Services
{
    public class ProductService
    {
        private readonly ProductRepository repository;

        public ProductService()
        {
            repository =
                new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return repository.GetAll();
        }
    }
}