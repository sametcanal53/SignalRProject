using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.SocialMedias
{
    public class ResultSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
