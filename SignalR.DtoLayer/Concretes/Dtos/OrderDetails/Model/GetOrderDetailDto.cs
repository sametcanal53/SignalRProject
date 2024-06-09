using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Model
{
    public class GetOrderDetailDto : OrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
