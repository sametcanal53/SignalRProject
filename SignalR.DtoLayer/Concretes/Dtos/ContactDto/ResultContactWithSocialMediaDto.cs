using SignalR.DtoLayer.Abstracts;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalR.DtoLayer.Concretes.Dtos.ContactDto
{
    public class ResultContactWithSocialMediaDto : BaseContactDto, IDto<int>
    {
        public int Id { get; set; }
        public List<GetSocialMediaDto> SocialMedias { get; set; }
    }
}
