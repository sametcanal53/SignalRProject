using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTableDto
{
    public class ResultMenuTableDto : BaseMenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
