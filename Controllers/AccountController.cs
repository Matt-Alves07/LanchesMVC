using LanchesMVC.Services;
using LanchesMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);

            var user = await _userManager.FindByNameAsync(loginVM.UserName);
            if (user != null)
            {
                if (user.PasswordHash == loginVM.Password)
                {
                    await _signInManager.SignInAsync(user, false);
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(loginVM.ReturnUrl);
                }
            }

            ModelState.AddModelError(String.Empty, "Falha ao realizar o login.");
            return View(loginVM);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel registroVM)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = registroVM.UserName };
                var result = await _userManager.CreateAsync(user, registroVM.Password);

                if (result.Succeeded)
                {
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Login", "Account");
                } else
                {
                    this.ModelState.AddModelError("Registro", "Falha ao registrar o usuário.");
                }
            }

            return View(registroVM);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
