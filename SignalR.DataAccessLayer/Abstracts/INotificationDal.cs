using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        List<Notification> GetNotifications(bool? isRead);
        int GetNotificationsCount(bool? isRead);
        bool ChangeNotificationStatus(int id, bool? isRead);
    }
}
