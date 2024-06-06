using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Products
{
    public class UpdateProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
