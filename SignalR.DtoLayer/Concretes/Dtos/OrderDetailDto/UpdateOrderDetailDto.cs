using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetailDto
{
    public class UpdateOrderDetailDto : BaseOrderDetailDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
