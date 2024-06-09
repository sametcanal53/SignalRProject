using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Products
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
