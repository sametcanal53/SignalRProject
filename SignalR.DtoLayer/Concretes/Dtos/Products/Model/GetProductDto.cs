using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Products.Model
{
    public class GetProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
