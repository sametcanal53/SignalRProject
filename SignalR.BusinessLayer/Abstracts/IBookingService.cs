using SignalR.Core.Enums;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IBookingService : IGenericService<Booking>
    {
        Booking ChangeBookingStatus(int id, EnumBookingStatus status);
    }
}
