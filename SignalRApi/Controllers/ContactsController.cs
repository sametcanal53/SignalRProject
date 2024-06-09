using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ContactsController : GenericController<Contact, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService, IMapper mapper) : base(contactService, mapper)
        {
            _contactService = contactService;
        }

        [HttpGet("GetContactWithSocialMedias")]
        public IActionResult GetContactWithSocialMedias() => Ok(_mapper.Map<List<GetContactWithSocialMediasDto>>(_contactService.GetContactWithSocialMedias()));
    }
}
