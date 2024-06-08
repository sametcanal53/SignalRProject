using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Discounts
{
    public class UpdateDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
