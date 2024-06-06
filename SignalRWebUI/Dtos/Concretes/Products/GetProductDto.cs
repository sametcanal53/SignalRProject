using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Products
{
    public class GetProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
