using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Baskets.Model
{
    public class GetBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
