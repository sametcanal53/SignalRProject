
using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Contacts
{
    public class ResultContactDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
