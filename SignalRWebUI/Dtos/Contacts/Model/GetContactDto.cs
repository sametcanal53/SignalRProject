using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Contacts.Model
{
    public class GetContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
