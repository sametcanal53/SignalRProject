using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class MoneyCaseManager : GenericManager<MoneyCase>, IMoneyCaseService
    {
        private readonly IMoneyCaseDal _dal;
        public MoneyCaseManager(IMoneyCaseDal dal) : base(dal)
        {
            _dal = dal;
        }

        public decimal TotalMoneyCaseAmount(DateTime? date) => _dal.TotalMoneyCaseAmount(date);
    }

}
