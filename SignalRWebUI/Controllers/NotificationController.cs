using SignalRWebUI.Dtos.Notifications.Create;
using SignalRWebUI.Dtos.Notifications.Model;
using SignalRWebUI.Dtos.Notifications.Update;

namespace SignalRWebUI.Controllers
{
    public class NotificationController : GenericController<GetNotificationDto, CreateNotificationDto, UpdateNotificationDto>
    {
        public NotificationController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

    }
}
