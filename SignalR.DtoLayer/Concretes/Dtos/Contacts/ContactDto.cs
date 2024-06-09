using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Contacts
{
    public class ContactDto : Dto
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FooterTitle { get; set; }
        public string FooterDescription { get; set; }
        public string OpenDays { get; set; }
        public string OpenDaysDescription { get; set; }
        public string OpenHours { get; set; }
    }
}
