using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Discounts.Update
{
    public class UpdateDiscountDto : DiscountDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
