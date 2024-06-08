using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.OrderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class OrderController : GenericController<Order, ResultOrderDto, GetOrderDto, CreateOrderDto, UpdateOrderDto>
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
        }

        [HttpGet("OrderCount")]
        public IActionResult OrderCount(bool? isActive) => Ok(_service.OrderCount(isActive));

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice(bool? isActive) => Ok(_service.LastOrderPrice(isActive));
    }
}