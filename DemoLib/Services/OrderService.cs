using DemoLib.Models;
using DemoLib.Repositories;
using System.Collections.Generic;

namespace DemoLib.Services
{
    public class OrderService
    {
        private readonly OrderRepository repository;

        public OrderService()
        {
            repository =
                new OrderRepository();
        }

        public List<Order> GetOrders()
        {
            return repository.GetAll();
        }
    }
}