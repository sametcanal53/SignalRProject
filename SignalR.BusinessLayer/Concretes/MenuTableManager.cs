using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class MenuTableManager : GenericManager<MenuTable>, IMenuTableService
    {
        public MenuTableManager(IMenuTableDal menuTableDal) : base(menuTableDal)
        {
        }
    }
}
