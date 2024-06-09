using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.SocialMedias.Model
{
    public class GetSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
