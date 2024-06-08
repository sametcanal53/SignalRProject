using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IOrderService : IGenericService<Order>
    {
        decimal LastOrderPrice(bool? isActive = default);
    }
}
