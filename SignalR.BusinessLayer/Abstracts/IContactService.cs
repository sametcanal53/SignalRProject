using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IContactService : IGenericService<Contact>
    {
        List<Contact> GetContactWithSocialMedias();

    }
}
