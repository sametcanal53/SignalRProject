using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Baskets.Update
{
    public class UpdateBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
