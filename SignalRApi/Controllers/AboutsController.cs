using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class AboutsController : GenericController<About, GetAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutsController(IAboutService aboutService, IMapper mapper) : base(aboutService, mapper)
        {
        }
    }
}
