using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : GenericController<Contact, IContactService, ResultContactDto, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IContactService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
