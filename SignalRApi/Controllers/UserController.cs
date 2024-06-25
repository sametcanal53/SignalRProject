using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.DtoLayer.Concretes.Dtos.Users;
using SignalR.DtoLayer.Concretes.Dtos.Users.Create;
using SignalR.EntityLayer.Entities;
using System.Security.Claims;

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
        public async Task<IActionResult> Register(CreateUserDto createUserDto)
        {

            var x = new User
            {
                Name = createUserDto.Name,
                Surname = createUserDto.Surname,
                UserName = createUserDto.Username,
                Email = createUserDto.Email
            };

            var xa = await _userManager.CreateAsync(x, createUserDto.Password);
            var y = await _userManager.AddToRoleAsync(x, "User");
            return Ok(x);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, loginDto.IsPersistent, false);
            return Ok(result);
        }

    }
}
