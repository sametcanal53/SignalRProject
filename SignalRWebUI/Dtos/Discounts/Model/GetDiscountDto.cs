using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Discounts.Model
{
    public class GetDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
