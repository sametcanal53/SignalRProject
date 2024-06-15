using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Users.Model
{
    public class GetUserDto : UserDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
