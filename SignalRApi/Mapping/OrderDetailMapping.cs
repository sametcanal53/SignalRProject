using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetailDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class OrderDetailMapping : Profile
    {
        public OrderDetailMapping()
        {
            CreateMap<OrderDetail, ResultOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, GetOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, UpdateOrderDetailDto>().ReverseMap();
        }
    }
}
