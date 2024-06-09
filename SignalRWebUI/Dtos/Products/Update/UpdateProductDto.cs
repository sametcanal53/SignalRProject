using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Products.Update
{
    public class UpdateProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
