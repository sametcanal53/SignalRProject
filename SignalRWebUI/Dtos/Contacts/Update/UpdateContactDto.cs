using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Contacts.Update
{
    public class UpdateContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
