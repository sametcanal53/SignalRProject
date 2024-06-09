using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Orders.Update
{
    public class UpdateOrderDto : OrderDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
