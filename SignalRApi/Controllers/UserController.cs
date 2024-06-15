using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.Concretes.Dtos.Users;
using SignalR.DtoLayer.Concretes.Dtos.Users.Create;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class UserController : GenericController
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public UserController(
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(CreateUserDto createUserDto) => Ok(await _userManager.CreateAsync(new User
        {
            Name = createUserDto.Name,
            Surname = createUserDto.Surname,
            UserName = createUserDto.Username,
            Email = createUserDto.Email
        }, createUserDto.Password));

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto) => Ok(await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, loginDto.IsPersistent, true));
    }
}
