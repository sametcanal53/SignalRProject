using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ContactController : GenericController<Contact, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IContactService contactService, IMapper mapper) : base(contactService, mapper)
        {
        }

    }
}
