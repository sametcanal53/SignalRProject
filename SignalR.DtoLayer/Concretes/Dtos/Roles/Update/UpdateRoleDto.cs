using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Roles.Update
{
    public class UpdateRoleDto : RoleDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
