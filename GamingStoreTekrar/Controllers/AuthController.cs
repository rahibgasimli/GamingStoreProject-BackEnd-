using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Enums;
using GamingStoreTekrar.Extensions;
using GamingStoreTekrar.Models;
using GamingStoreTekrar.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GamingStoreTekrar.Controllers
{
    public class AuthController : Controller
    {
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IStorageService storageService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _storageService = storageService;
        }

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IStorageService _storageService;


        public IActionResult Login(string? returnUrl)
        {
            ViewData["hasError"] = false;
            return View();
        }

        public IActionResult Register()
        {
            ViewData["hasError"] = false;
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string? returnUrl)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("authError", "Sifre ve ya mail yanlishdir.");
                ViewData["hasError"] = true;
                return View(model);
            }


            var res = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

            if (!res.Succeeded)
            {
                ModelState.AddModelError("authError", "Sifre ve ya mail yanlishdir.");
                ViewData["hasError"] = true;
                return View(model);
            }

            User.Claims.Append(new Claim(ClaimTypes.Name, user.FName));

            if (returnUrl != null && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                ViewData["hasError"] = true;
                return View(model);
            }

            var uploaded = await _storageService.UploadFileAsync("profile-photos", model.ProfilePhoto);

            var profilePhoto = uploaded.FullPath;

            if (_storageService is LocalStorageService)
            {
                profilePhoto = $"uploads/{profilePhoto}";
            }

            var usr = new AppUser()
            {
                FName = model.FirstName,
                LName = model.LastName,
                Age = model.Age,
                Email = model.Email,
                UserName = model.FirstName + model.LastName,
                ProfilePhoto = profilePhoto
            };

            var res = await _userManager.CreateAsync(usr, model.Password);

            if (!res.Succeeded)
            {
                ViewData["hasError"] = true;
                var regErrors = res.Errors.ErrorsToString();
                ModelState.AddModelError("registerErrors", regErrors);
                return View(model);
            }

            var roleRes = await _userManager.AddToRoleAsync(usr,nameof(RoleTypes.Client));

            if (roleRes.Succeeded)
            {
                TempData["succesMsg"] = "Qeydiyyata alindiniz";
                return RedirectToAction("Login");
            }

            var errors = roleRes.Errors.ErrorsToString();
            ModelState.AddModelError("roleErrors", errors);
            ViewData["hasError"] = true;

            return View(model);
        }

    }
}
