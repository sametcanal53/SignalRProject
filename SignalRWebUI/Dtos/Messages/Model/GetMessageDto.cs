using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Messages.Model
{
    public class GetMessageDto : MessageDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
