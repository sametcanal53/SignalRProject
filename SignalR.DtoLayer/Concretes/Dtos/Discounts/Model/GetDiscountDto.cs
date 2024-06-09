using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Discounts.Model
{
    public class GetDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
