using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Abouts.Model
{
    public class GetAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
