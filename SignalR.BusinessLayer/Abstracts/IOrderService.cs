using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IOrderService : IGenericService<Order>
    {
        int OrderCount(bool? isActive);
        decimal LastOrderPrice(bool? isActive);
    }
}
