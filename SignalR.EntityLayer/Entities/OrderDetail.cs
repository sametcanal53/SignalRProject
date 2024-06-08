using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class OrderDetail : Entity<int>
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
