using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Abouts
{
    public class GetAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
