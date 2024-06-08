
using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class ResultContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
