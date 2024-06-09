using SignalR.Core.Abstracts;
using SignalRWebUI.Dtos.Contacts;

namespace SignalRWebUI.Dtos.SocialMedias.Model
{
    public class GetSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
        public ContactDto Contact { get; set; }
    }
}
