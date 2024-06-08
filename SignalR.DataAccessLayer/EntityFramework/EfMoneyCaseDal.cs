using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        private readonly SignalRContext _context;
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public decimal TotalMoneyCaseAmount(DateTime? date) => _context.MoneyCases.Where(mc => !date.HasValue || mc.Date == date).Sum(mc => mc.TotalAmount);
    }
}
