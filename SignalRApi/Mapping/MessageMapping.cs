using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Messages;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Create;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Model;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, MessageDto>().ReverseMap();
            CreateMap<Message, GetMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
        }
    }
}
