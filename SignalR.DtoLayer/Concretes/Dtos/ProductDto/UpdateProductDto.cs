using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.ProductDto
{
    public class UpdateProductDto : BaseProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
