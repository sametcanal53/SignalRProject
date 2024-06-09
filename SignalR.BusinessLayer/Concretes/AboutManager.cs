using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class AboutManager : GenericManager<About>, IAboutService
    {
        public AboutManager(IAboutDal aboutDal) : base(aboutDal)
        {
        }
    }
}
