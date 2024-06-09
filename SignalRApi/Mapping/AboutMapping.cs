using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Abouts;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Abouts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
