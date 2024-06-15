using SignalR.Core.Enums;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        Booking ChangeBookingStatus(int id, EnumBookingStatus status);
    }
}
