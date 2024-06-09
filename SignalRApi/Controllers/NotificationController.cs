using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Create;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Model;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class NotificationController : GenericController<Notification, GetNotificationDto, CreateNotificationDto, UpdateNotificationDto>
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService, IMapper mapper) : base(notificationService, mapper)
        {
            _notificationService = notificationService;
        }

        [HttpGet("GetNotifications")]
        public IActionResult GetNotifications(bool? isRead) => Ok(_mapper.Map<List<GetNotificationDto>>(_notificationService.GetNotifications(isRead)));

        [HttpGet("GetNotificationsCount")]
        public IActionResult GetNotificationsCount(bool? isRead) => Ok(_notificationService.GetNotificationsCount(isRead));
    }
}
