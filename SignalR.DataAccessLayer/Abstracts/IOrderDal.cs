using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IOrderDal : IGenericDal<Order>
    {
        decimal LastOrderPrice(bool? isActive);

    }
}
