using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.MoneyCaseDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MoneyCaseMapping : Profile
    {
        public MoneyCaseMapping()
        {
            CreateMap<MoneyCase, ResultMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, GetMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, CreateMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, UpdateMoneyCaseDto>().ReverseMap();
        }
    }
}
