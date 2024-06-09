using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Orders.Model
{
    public class GetOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
