using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Notifications.Update
{
    public class UpdateNotificationDto : NotificationDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
