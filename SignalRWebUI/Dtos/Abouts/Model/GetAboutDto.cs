using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Abouts.Model
{
    public class GetAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
