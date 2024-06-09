using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Create;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Model;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class SocialMediasController : GenericController<SocialMedia, GetSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper) : base(socialMediaService, mapper)
        {
        }
    }
}
