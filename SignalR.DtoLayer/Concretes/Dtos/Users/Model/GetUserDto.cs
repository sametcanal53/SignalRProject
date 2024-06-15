using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Users.Model
{
    public class GetUserDto : UserDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
