using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Update
{
    public class UpdateOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
