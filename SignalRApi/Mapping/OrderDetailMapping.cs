using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Create;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Model;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class OrderDetailMapping : Profile
    {
        public OrderDetailMapping()
        {
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, GetOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, UpdateOrderDetailDto>().ReverseMap();
        }
    }
}
