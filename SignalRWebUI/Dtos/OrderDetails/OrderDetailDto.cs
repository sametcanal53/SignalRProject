using SignalR.Core.Concretes;

namespace SignalRWebUI.Dtos.OrderDetails
{
    public class OrderDetailDto : Dto
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
