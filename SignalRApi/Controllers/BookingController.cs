using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Create;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Model;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class BookingController : GenericController<Booking, GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IBookingService bookingService, IMapper mapper) : base(bookingService, mapper)
        {
        }
    }
}
