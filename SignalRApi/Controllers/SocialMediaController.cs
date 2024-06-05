using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : GenericController<SocialMedia, ISocialMediaService, ResultSocialMediaDto, GetSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(ISocialMediaService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
