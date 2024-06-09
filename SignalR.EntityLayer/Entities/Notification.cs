using SignalR.Core.Concretes;
using SignalR.Core.Enums;

namespace SignalR.EntityLayer.Entities
{
    public class Notification : Entity<int>
    {
        public EnumNotificationType Type { get; set; }
        public EnumIcon Icon { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
    }
}
