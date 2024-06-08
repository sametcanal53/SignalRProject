using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class AboutController : GenericController<About, ResultAboutDto, GetAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutController(IAboutService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
