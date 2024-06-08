using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ContactsController : GenericController<Contact, ResultContactDto, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactsController(IContactService contactService, IMapper mapper) : base(contactService, mapper)
        {
        }
    }
}
