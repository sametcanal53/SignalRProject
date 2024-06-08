using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        private readonly IContactDal _dal;
        public ContactManager(IContactDal dal) : base(dal)
        {
            _dal = dal;
        }

        public List<Contact> GetContactWithSocialMedias() => _dal.GetContactWithSocialMedias();
    }
}
