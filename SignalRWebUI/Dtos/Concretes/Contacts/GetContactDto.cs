using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class GetContactDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
