using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class SocialMediaController : GenericController<SocialMedia, ResultSocialMediaDto, GetSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(ISocialMediaService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
