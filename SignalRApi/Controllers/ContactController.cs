using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : GenericController<Contact, ResultContactDto, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IGenericService<Contact> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
