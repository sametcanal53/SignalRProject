using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.ControllerRequest;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Create;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Model;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class NotificationController : GenericController<Notification, GetNotificationDto, CreateNotificationDto, UpdateNotificationDto>
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;
        public NotificationController(INotificationService notificationService, IMapper mapper) : base(notificationService, mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpPost("GetNotifications")]
        public IActionResult GetNotifications(GetNotificationsRequest request) => Ok(_mapper.Map<List<GetNotificationDto>>(_notificationService.GetNotifications(request.IsRead)));

        [HttpPost("GetNotificationsCount")]
        public IActionResult GetNotificationsCount(GetNotificationsCountRequest request) => Ok(_notificationService.GetNotificationsCount(request.IsRead));

        [HttpPost("ChangeNotificationStatus")]
        public IActionResult ChangeNotificationStatus(ChangeNotificationStatusRequest request) => Ok(_notificationService.ChangeNotificationStatus(request.Id, request.IsRead));
    }
}
