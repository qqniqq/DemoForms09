using System;

namespace DemoLib.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int PickupPointId { get; set; }

        public string ClientName { get; set; }

        public string ReceiveCode { get; set; }

        public int StatusId { get; set; }

        public PickupPoint PickupPoint { get; set; }

        public OrderStatus Status { get; set; }
    }
}