using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Users.Update
{
    public class UpdateUserDto : UserDto
    {
        public string ConfirmPassword { get; set; }
    }
}
