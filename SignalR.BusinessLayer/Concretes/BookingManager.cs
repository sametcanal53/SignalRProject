using SignalR.BusinessLayer.Abstracts;
using SignalR.Core.Enums;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class BookingManager : GenericManager<Booking>, IBookingService
    {
        private readonly IBookingDal _bookingDal;
        public BookingManager(IBookingDal bookingDal) : base(bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public Booking ChangeBookingStatus(int id, EnumBookingStatus status) => _bookingDal.ChangeBookingStatus(id, status);
    }
}
