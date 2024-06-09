using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Notifications;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Create;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Model;
using SignalR.DtoLayer.Concretes.Dtos.Notifications.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class NotificationMapping : Profile
    {
        public NotificationMapping()
        {
            CreateMap<Notification, NotificationDto>().ReverseMap();
            CreateMap<Notification, GetNotificationDto>().ReverseMap();
            CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
        }
    }
}
