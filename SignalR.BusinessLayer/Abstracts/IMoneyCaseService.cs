using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        decimal TotalMoneyCaseAmount(DateTime? date = default);
    }
}
