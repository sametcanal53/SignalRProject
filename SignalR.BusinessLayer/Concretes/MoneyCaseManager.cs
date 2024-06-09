using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class MoneyCaseManager : GenericManager<MoneyCase>, IMoneyCaseService
    {
        private readonly IMoneyCaseDal _moneyCaseDal;
        public MoneyCaseManager(IMoneyCaseDal moneyCaseDal) : base(moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }

        public decimal TotalMoneyCaseAmount(DateTime? date) => _moneyCaseDal.TotalMoneyCaseAmount(date);
    }

}
