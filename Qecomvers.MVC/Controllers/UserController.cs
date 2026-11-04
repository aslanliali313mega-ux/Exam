using Microsoft.AspNetCore.Mvc;
using Qecomvers.Business.DTOs.User;
using Qecomvers.Business.Services.Interfaces;

namespace Qecomvers.MVC.Controllers
{
    public class UserController(IUserService _service) : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var result = await _service.LoginAsync(dto);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(dto);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            await _service.RegisterAsync(dto);
            return RedirectToAction(nameof(Login));
        }



    }
}
