using SignalR.Enums;

namespace SignalRWebUI.Dtos.Orders
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
