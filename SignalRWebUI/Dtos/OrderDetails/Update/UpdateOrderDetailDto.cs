using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.OrderDetails.Update
{
    public class UpdateOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
