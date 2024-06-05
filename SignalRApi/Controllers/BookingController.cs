using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : GenericController<Booking, IBookingService, ResultBookingDto, GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IBookingService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
