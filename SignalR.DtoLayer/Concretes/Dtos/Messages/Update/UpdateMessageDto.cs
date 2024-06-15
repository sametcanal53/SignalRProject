using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Messages.Update
{
    public class UpdateMessageDto : MessageDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
