using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal) : base(contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetContactWithSocialMedias() => _contactDal.GetContactWithSocialMedias();
    }
}
