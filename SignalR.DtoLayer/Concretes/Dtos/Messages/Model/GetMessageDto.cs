using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Messages.Model
{
    public class GetMessageDto : MessageDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
