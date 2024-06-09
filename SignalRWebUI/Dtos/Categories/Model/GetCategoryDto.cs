using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.Products;

namespace SignalRWebUI.Dtos.Categories.Model
{
    public class GetCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
