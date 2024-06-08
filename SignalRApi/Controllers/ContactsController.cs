using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class ContactsController : GenericController<Contact, ResultContactDto, GetContactDto, CreateContactDto, UpdateContactDto>
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactsController(IContactService contactService, IMapper mapper) : base(contactService, mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet("GetContactWithSocialMedias")]
        public IActionResult GetContactWithSocialMedias() => Ok(_mapper.Map<List<ResultContactWithSocialMediaDto>>(_contactService.GetContactWithSocialMedias()));
    }
}
