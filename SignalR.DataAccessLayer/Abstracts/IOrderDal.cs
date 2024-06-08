using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IOrderDal : IGenericDal<Order>
    {
        int OrderCount(bool? isActive);
        decimal LastOrderPrice(bool? isActive);

    }
}
