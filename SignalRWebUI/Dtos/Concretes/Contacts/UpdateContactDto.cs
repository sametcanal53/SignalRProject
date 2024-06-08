using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class UpdateContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
