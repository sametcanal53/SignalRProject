using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Products.Model
{
    public class GetProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
