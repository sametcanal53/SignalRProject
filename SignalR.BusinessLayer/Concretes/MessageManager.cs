using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class MessageManager : GenericManager<Message>, IMessageService
    {
        public MessageManager(IMessageDal messageDal) : base(messageDal)
        {
        }
    }
}
