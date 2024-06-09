using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.SocialMedias;

namespace SignalRWebUI.Dtos.Contacts.Model
{
    public class GetContactDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<SocialMediaDto> SocialMedias { get; set; }

    }
}
