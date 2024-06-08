using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class BookingsController : GenericController<Booking, ResultBookingDto, GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingsController(IBookingService bookingService, IMapper mapper) : base(bookingService, mapper)
        {
        }
    }
}
