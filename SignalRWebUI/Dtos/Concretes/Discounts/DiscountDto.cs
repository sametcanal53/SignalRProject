using SignalRWebUI.Dtos.Concretes.Base;

namespace SignalRWebUI.Dtos.Concretes.Discounts
{
    public class DiscountDto : Dto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
    }
}
