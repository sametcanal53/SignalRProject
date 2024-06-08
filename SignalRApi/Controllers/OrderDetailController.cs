﻿using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.OrderDetailDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class OrderDetailController : GenericController<OrderDetail, ResultOrderDetailDto, GetOrderDetailDto, CreateOrderDetailDto, UpdateOrderDetailDto>
    {
        public OrderDetailController(IOrderDetailService orderDetailService, IMapper mapper) : base(orderDetailService, mapper)
        {
        }
    }
}
