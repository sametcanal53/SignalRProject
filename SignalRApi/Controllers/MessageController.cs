using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Create;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Model;
using SignalR.DtoLayer.Concretes.Dtos.Messages.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class MessageController : GenericController<Message, GetMessageDto, CreateMessageDto, UpdateMessageDto>
    {
        public MessageController(IMessageService messageService, IMapper mapper) : base(messageService, mapper)
        {
        }
    }
}
