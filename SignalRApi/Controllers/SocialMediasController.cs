using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class SocialMediasController : GenericController<SocialMedia, ResultSocialMediaDto, GetSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper) : base(socialMediaService, mapper)
        {
        }
    }
}
