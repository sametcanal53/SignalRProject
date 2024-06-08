using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class SocialMediaManager : GenericManager<SocialMedia>, ISocialMediaService
    {
        public SocialMediaManager(ISocialMediaDal dal) : base(dal)
        {
        }
    }
}
