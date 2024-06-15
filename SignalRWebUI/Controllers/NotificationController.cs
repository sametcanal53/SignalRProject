using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Notifications;
using SignalRWebUI.Dtos.Notifications.Create;
using SignalRWebUI.Dtos.Notifications.Model;
using SignalRWebUI.Dtos.Notifications.Update;
using System.Net.Http;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class NotificationController : GenericController<GetNotificationDto, CreateNotificationDto, UpdateNotificationDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public NotificationController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ChangeNotificationStatus(int id, bool? isRead = default)
        {
            var client = _httpClientFactory.CreateClient();
            var x = await client.GetAsync($"https://localhost:5353/api/{ControllerContext.ActionDescriptor.ControllerName}/ChangeNotificationStatus/{id}/{isRead}");
            return RedirectToAction("Index");
        }
    }
}

