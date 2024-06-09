using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Contacts;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Contacts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
        }
    }
}
