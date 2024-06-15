using SignalR.Core.Enums;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }

        public Booking ChangeBookingStatus(int id, EnumBookingStatus status)
        {
            var booking = GetById(id);
            booking.Status = status;
            return base.Update(booking);
        }
    }
}
