using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Abouts
{
    public class ResultAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
