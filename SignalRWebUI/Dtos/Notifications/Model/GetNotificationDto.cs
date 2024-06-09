using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Notifications.Model
{
    public class GetNotificationDto : NotificationDto, IDto<int>
    {
        public int Id { get; set; }

    }
}
