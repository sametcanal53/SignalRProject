using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Create;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.ControllerRequest;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Model;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class BookingController : GenericController<Booking, GetBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        public BookingController(IBookingService bookingService, IMapper mapper) : base(bookingService, mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpPatch("ChangeBookingStatus")]
        public IActionResult ChangeBookingStatus(ChangeBookingStatusRequest request) => Ok(_mapper.Map<GetBookingDto>(_bookingService.ChangeBookingStatus(request.Id, request.Status)));
    }
}
