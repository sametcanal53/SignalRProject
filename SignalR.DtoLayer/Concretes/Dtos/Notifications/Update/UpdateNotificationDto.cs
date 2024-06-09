using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Notifications.Update
{
    public class UpdateNotificationDto : NotificationDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
