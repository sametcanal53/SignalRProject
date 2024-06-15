namespace SignalR.DtoLayer.Concretes.Dtos.Notifications.ControllerRequest
{
    public class ChangeNotificationStatusRequest
    {
        public int Id { get; set; }
        public bool? IsRead { get; set; }
    }
}
