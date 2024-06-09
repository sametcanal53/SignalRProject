using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Create;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Model;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<Order, GetOrderDto>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();
        }
    }
}
