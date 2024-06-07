using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Discounts
{
    public class GetDiscountDto : BaseDiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
