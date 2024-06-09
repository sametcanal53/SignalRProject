using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Discounts
{
    public class DiscountDto : Dto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
    }
}
