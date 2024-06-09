using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.SocialMedias.Model;

namespace SignalRWebUI.Dtos.Contacts.Model
{
    public class GetContactWithSocialMediasDto : ContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetSocialMediaDto> SocialMedias { get; set; }
    }
}
