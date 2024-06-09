using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface INotificationService : IGenericService<Notification>
    {
        List<Notification> GetNotifications(bool? isRead);
        int GetNotificationsCount(bool? isRead);
    }
}
