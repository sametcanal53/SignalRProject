using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Messages.Update
{
    public class UpdateMessageDto : MessageDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
