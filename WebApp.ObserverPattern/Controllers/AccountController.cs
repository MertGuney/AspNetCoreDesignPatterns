using AspNetCoreDesignPatterns.BaseProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ObserverPattern.Models;
using WebApp.ObserverPattern.Observer;

namespace AspNetCoreDesignPatterns.BaseProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserObserverSubject _userObserverSubject;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, UserObserverSubject userObserverSubject)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userObserverSubject = userObserverSubject;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var hasUser = await _userManager.FindByEmailAsync(email);
            if (hasUser == null) return View();
            var signInResult = await _signInManager.PasswordSignInAsync(hasUser, password, true, false);
            if (!signInResult.Succeeded) return View();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateDto userCreateDto)
        {
            var appUser = new AppUser() { UserName = userCreateDto.Username, Email = userCreateDto.Email };

            var identityResult = await _userManager.CreateAsync(appUser, userCreateDto.Password);
            if (identityResult.Succeeded)
            {
                _userObserverSubject.NotifyObserver(appUser);
                ViewBag.message = "Üyelik işlemi başarıyla gerçekleşti";
            }
            else
            {
                ViewBag.message = identityResult.Errors.ToList().First().Description;
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
