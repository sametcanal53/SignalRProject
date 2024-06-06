using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Products
{
    public class ResultProductDto : ProductDto, IDto<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
