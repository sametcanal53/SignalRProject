using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.Concretes.Dtos.Users.Create;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class UserController : GenericController
    {
        private readonly UserManager<User> _userManager;
        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Name = createUserDto.Name,
                Surname = createUserDto.Surname,
                UserName = createUserDto.Username,
                Email = createUserDto.Email
            };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);
            return Ok(result);
        }
    }
}
