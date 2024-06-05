﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : GenericController<Booking, ResultBookingDto, GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IGenericService<Booking> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
