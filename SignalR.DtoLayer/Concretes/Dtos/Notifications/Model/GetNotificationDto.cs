using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Notifications.Model
{
    public class GetNotificationDto : NotificationDto, IDto<int>
    {
        public int Id { get; set; }

    }
}
