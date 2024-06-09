using SignalR.Core.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class OrderDetail : Entity<int>
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
