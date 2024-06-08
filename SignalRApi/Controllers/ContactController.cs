using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ContactController : GenericController<Contact, ResultContactDto, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IContactService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
