using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class AboutController : GenericController<About, ResultAboutDto, GetAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutController(IGenericService<About> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
