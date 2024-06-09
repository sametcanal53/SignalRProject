using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Create;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Model;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetails.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class OrderDetailController : GenericController<OrderDetail, GetOrderDetailDto, CreateOrderDetailDto, UpdateOrderDetailDto>
    {
        public OrderDetailController(IOrderDetailService orderDetailService, IMapper mapper) : base(orderDetailService, mapper)
        {
        }
    }
}
