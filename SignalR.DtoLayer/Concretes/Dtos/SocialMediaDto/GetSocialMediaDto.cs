using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class GetSocialMediaDto : BaseSocialMediaDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
