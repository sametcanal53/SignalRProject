using SignalR.Core.Concretes;

namespace SignalRWebUI.Dtos.Messages
{
    public class MessageDto : Dto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
    }
}
