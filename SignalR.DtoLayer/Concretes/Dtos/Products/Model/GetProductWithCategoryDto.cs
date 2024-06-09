using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Products.Model
{
    public class GetProductWithCategoryDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
