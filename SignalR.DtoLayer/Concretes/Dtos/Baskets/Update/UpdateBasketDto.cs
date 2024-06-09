using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Baskets.Update
{
    public class UpdateBasketDto : BasketDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
