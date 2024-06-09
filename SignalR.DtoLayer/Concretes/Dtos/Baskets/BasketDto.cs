using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Baskets
{
    public class BasketDto : Dto
    {
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
        public int Amount { get; set; }
    }
}
