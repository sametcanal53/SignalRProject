using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Create;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Model;
using SignalR.DtoLayer.Concretes.Dtos.Orders.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class OrderController : GenericController<Order, GetOrderDto, CreateOrderDto, UpdateOrderDto>
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService, IMapper mapper) : base(orderService, mapper)
        {
            _orderService = orderService;
        }

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice(bool? isActive) => Ok(_orderService.LastOrderPrice(isActive));
    }
}