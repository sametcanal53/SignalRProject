using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class ResultSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
