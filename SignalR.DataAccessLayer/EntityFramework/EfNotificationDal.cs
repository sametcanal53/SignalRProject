using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context)
        {
        }

        public List<Notification> GetNotifications(bool? isRead) => GetList().Where(n => !isRead.HasValue || n.IsRead == isRead).ToList();

        public int GetNotificationsCount(bool? isRead) => GetNotifications(isRead).Count;

        public bool NotificationStatusChange(int id, bool? isRead)
        {
            var notification = GetById(id);
            notification.IsRead = isRead ?? !notification.IsRead;
            Update(notification);
            return true;
        }

    }
}
