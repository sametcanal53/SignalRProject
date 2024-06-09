using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Create;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Model;
using SignalR.DtoLayer.Concretes.Dtos.Bookings.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
