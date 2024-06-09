using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Abouts.Update
{
    public class UpdateAboutDto : AboutDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
