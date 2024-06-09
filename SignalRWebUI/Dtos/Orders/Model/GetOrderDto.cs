using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.OrderDetails;

namespace SignalRWebUI.Dtos.Orders.Model
{
    public class GetOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }

    }
}
