using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Discounts.Update
{
    public class UpdateDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
