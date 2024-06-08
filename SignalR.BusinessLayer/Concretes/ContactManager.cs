using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        public ContactManager(IContactDal dal) : base(dal)
        {
        }
    }
}
