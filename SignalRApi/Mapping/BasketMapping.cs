using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Baskets;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Create;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Model;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, BasketDto>().ReverseMap();
            CreateMap<Basket, GetBasketDto>().ReverseMap();
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
            CreateMap<Basket, UpdateBasketDto>().ReverseMap();
        }
    }
}
