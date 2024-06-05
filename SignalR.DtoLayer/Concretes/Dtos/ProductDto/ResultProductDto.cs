using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.ProductDto
{
    public class ResultProductDto : BaseProductDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
