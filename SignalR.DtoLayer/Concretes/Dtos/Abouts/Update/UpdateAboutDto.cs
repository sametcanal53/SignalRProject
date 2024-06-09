using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Abouts.Update
{
    public class UpdateAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
