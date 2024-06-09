using SignalR.Core.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Products;

namespace SignalR.DtoLayer.Concretes.Dtos.Categories.Model
{
    public class GetCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
