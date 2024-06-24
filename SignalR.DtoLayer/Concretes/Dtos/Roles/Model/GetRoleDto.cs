using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Roles.Model
{
    public class GetRoleDto : RoleDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
