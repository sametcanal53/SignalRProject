using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.DiscountDto
{
    public class GetDiscountDto : BaseDiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
