using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Create;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Model;
using SignalR.DtoLayer.Concretes.Dtos.SocialMedias.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        }
    }
}
