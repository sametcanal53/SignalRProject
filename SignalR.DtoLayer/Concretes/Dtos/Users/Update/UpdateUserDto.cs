using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Users.Update
{
    public class UpdateUserDto : UserDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
