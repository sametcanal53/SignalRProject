using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Discounts
{
    public class ResultDiscountDto : BaseDiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
