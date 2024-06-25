using SignalR.Core.Concretes;

namespace SignalRWebUI.Dtos.Users
{
    public class LoginDto : Dto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsPersistent { get; set; } = false;
    }
}
