using SignalR.EntityLayer.Concretes;
using SignalR.Enums;

namespace SignalR.EntityLayer.Entities
{
    public class Order : Entity<int>
    {
        public string TableNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public EnumOrderStatus Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
