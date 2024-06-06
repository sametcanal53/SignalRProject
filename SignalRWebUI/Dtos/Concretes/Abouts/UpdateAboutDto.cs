using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Abouts
{
    public class UpdateAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
