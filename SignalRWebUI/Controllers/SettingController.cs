using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.Dtos.Users.Update;

namespace SignalRWebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<User> _userManager;

        public SettingController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return RedirectToAction("Login", "User");
            UpdateUserDto updateUserDto = new UpdateUserDto();
            updateUserDto.Name = user.Name;
            updateUserDto.Surname = user.Surname;
            updateUserDto.Email = user.Email;
            updateUserDto.Username = user.UserName;
            return View(updateUserDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateUserDto updateUserDto)
        {
            if (!updateUserDto.Password.Equals(updateUserDto.ConfirmPassword)) return View();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = updateUserDto.Name;
            user.Surname = updateUserDto.Surname;
            user.Email = updateUserDto.Email;
            user.UserName = updateUserDto.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, updateUserDto.Password);
            var x = await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }
    }
}
