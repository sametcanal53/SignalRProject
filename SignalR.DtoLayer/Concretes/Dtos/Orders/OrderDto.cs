using SignalR.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.Orders
{
    public class OrderDto
    {
        public string TableNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public EnumOrderStatus Status { get; set; }
    }
}
