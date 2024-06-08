using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Discounts
{
    public class GetDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
