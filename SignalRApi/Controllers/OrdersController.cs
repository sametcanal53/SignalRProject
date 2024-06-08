using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.OrderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class OrdersController : GenericController<Order, ResultOrderDto, GetOrderDto, CreateOrderDto, UpdateOrderDto>
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService, IMapper mapper) : base(orderService, mapper)
        {
            _orderService = orderService;
        }

        [HttpGet("OrderCount")]
        public IActionResult OrderCount(bool? isActive) => Ok(_orderService.OrderCount(isActive));

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice(bool? isActive) => Ok(_orderService.LastOrderPrice(isActive));
    }
}