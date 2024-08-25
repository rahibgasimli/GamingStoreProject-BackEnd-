using CloudinaryDotNet.Actions;
using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreTekrar.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    public class AuthController : Controller
    {
        public AuthController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public IActionResult Login()
        {
            return View();
        }

        [Authorize(Roles = nameof(Role.Admin), AuthenticationSchemes = "AdminAuth")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(scheme: "AdminAuth");

            return RedirectToAction("Login","Auth");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usr = await _userManager.FindByEmailAsync(model.Email);

            if(usr == null)
            {
                ModelState.AddModelError("authError", "There isn't such admin");
                return View(model);
            }

            var res = await _signInManager.CheckPasswordSignInAsync(usr,model.Password,false);
            
            if (!res.Succeeded)
            {
                ModelState.AddModelError("authError", "Password or email is wrong!");
                return View(model);
            }
            
            var claimsPrinc = await _signInManager.CreateUserPrincipalAsync(usr);

            await HttpContext.SignInAsync("AdminAuth",claimsPrinc);



            return RedirectToAction("Index", "Home");
        }
    }
}
