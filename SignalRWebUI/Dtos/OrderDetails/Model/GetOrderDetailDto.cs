using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.OrderDetails.Model
{
    public class GetOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
