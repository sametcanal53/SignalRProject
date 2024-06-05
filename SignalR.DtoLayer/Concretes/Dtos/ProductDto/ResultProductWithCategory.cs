using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.ProductDto
{
    public class ResultProductWithCategory : BaseProductDto, IDto<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
