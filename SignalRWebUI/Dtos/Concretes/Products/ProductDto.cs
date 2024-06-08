using SignalRWebUI.Dtos.Concretes.Base;

namespace SignalRWebUI.Dtos.Concretes.Products
{
    public class ProductDto : Dto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
