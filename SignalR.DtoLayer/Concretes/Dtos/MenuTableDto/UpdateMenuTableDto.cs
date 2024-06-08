using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTableDto
{
    public class UpdateMenuTableDto : BaseMenuTableDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
