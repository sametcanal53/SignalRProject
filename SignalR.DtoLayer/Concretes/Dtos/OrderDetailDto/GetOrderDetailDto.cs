using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetailDto
{
    public class GetOrderDetailDto : BaseOrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
