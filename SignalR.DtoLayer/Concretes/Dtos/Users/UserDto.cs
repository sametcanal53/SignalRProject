using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Users
{
    public class UserDto : Dto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
