using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<Basket> Baskets { get; set; }
    }
}
