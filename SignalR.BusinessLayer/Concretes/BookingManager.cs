using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class BookingManager : GenericManager<Booking>, IBookingService
    {
        public BookingManager(IGenericDal<Booking> dal) : base(dal)
        {
        }
    }
}
