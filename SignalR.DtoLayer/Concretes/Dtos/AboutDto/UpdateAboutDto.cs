using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.AboutDto
{
    public class UpdateAboutDto : BaseAboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
