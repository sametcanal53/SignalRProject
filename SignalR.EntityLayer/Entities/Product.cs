﻿using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
