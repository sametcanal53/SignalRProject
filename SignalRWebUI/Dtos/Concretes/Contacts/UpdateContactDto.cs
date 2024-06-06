using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class UpdateContactDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
