using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Discounts;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, DiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}
