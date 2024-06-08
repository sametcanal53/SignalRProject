using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class AboutsController : GenericController<About, ResultAboutDto, GetAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutsController(IAboutService aboutService, IMapper mapper) : base(aboutService, mapper)
        {
        }
    }
}
