using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Products.Update
{
    public class UpdateProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
