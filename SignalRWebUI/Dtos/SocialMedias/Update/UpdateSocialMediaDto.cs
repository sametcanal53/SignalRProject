using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.SocialMedias.Update
{
    public class UpdateSocialMediaDto : SocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
