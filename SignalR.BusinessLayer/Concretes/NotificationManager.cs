using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class NotificationManager : GenericManager<Notification>, INotificationService
    {
        private readonly INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal) : base(notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public List<Notification> GetNotifications(bool? isRead) => _notificationDal.GetNotifications(isRead);
        public int GetNotificationsCount(bool? isRead) => _notificationDal.GetNotificationsCount(isRead);
        public bool NotificationStatusChange(int id, bool? isRead) => _notificationDal.NotificationStatusChange(id, isRead);
    }
}
