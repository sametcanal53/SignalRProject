using SignalR.Core.Concretes;
using SignalR.Core.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.Notifications
{
    public class NotificationDto : Dto
    {
        public EnumNotificationType Type { get; set; } = EnumNotificationType.None;
        public EnumIcon Icon { get; set; } = EnumIcon.None;
        public string Description { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
    }
}
