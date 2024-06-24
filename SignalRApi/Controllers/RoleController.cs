using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.Concretes.Dtos.Roles.Create;
using SignalR.DtoLayer.Concretes.Dtos.Roles.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class RoleController : GenericController
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDto createRoleDto) => Ok(await _roleManager.CreateAsync(new Role { Name = createRoleDto.Name }));

        [HttpPatch]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto updateRoleDto)
        {
            var role = await _roleManager.FindByIdAsync(updateRoleDto.Id.ToString());
            role.Name = updateRoleDto.Name;
            return Ok(await _roleManager.UpdateAsync(role));
        }
    }
}
