using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Baskets.Model
{
    public class GetBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
