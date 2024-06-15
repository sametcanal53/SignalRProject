using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Users.Update
{
    public class UpdateUserDto : UserDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
