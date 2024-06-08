using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class GetContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
