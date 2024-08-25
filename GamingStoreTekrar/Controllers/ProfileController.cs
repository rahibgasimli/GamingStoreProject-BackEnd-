using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Models;
using GamingStoreTekrar.Services;
using GamingStoreTekrar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SessionMapper;
using System.Security.Claims;

namespace GamingStoreTekrar.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public ProfileController(UserManager<AppUser> userManager, IStorageService storageService)
        {
            this._userManager = userManager;
            _storageService = storageService;
        }

        private readonly UserManager<AppUser> _userManager;
        private readonly IStorageService _storageService;

        public async Task<IActionResult> Index()
        {
            var id = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (id == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }

            var usr = await _userManager.FindByIdAsync(id.Value);

            if (usr == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }


            var profileEdit = new ProfileEdit()
            {
                Id = usr.Id,
                FirstName = usr.FName,
                LastName = usr.LName,
                NickName = usr.UserName,
                Age = usr.Age,
                Email = usr.Email,
                ProfilePhotoUrl = usr.ProfilePhoto
            };

            var profileIndex = new ProfileIndex()
            {
                FullName = $"{usr.FName} {usr.LName}",
                Age = usr.Age,
                Email = usr.Email,
                ProfilePhoto = usr.ProfilePhoto
            };

            HttpContext.Session.SetAsJson<ProfileEdit>("usrDetails", profileEdit);

            return View(profileIndex);
        }


        public IActionResult Edit()
        {
            var details = HttpContext.Session.Get<ProfileEdit>("usrDetails");

            if (details == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }

            HttpContext.Session.Remove("usrDetails");

            var vm = new ProfileEditVm()
            {
                ProfileDetails = details
            };

            ViewData["hasError"] = false;



            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProfileEditVm vm)
        {
            var usr = await _userManager.FindByIdAsync(vm.ProfileDetails.Id);

            if (usr == null)
            {
                ViewData["msg"] = "There isn't such user";
                return View("Error");
            }

            var profilePhoto = "";
            if (vm.ProfileDetails.ProfilePhoto == null)
                profilePhoto = vm.ProfileDetails.ProfilePhotoUrl;
            else
            {
                var photoName = Path.GetFileName(vm.ProfileDetails.ProfilePhotoUrl);
                if (_storageService.HasFile("profile-photos", photoName))
                {
                    await _storageService.DeleteFileAsync("profile-photos", photoName);
                }
                var dto = await _storageService.UploadFileAsync("profile-photos", vm.ProfileDetails.ProfilePhoto);
                profilePhoto = dto.FullPath;
                if (_storageService is LocalStorageService)
                {
                    profilePhoto = $"uploads/{dto.FullPath}";
                }
            }


            usr.Email = vm.ProfileDetails.Email;
            usr.Age = vm.ProfileDetails.Age;
            usr.FName = vm.ProfileDetails.FirstName;
            usr.LName = vm.ProfileDetails.LastName;
            usr.ProfilePhoto = profilePhoto;
            usr.UserName = vm.ProfileDetails.NickName;

            var res = await _userManager.UpdateAsync(usr);

            if (res.Succeeded)
            {
                TempData["succesMsg"] = "Updated the profile";
                return RedirectToAction("Index");
            }

            var errors = string.Join("\n", res.Errors.Select(err => err.Description).ToList());
            ModelState.AddModelError("registerErrors", errors);
            ViewData["hasError"] = true;

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ProfileEditVm model)
        {
            var usr = await _userManager.FindByEmailAsync(model.ProfileDetails.Email);

            if(usr == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }

            var res = await _userManager.ChangePasswordAsync(usr,model.ChangeDetails.CurrentPassword,model.ChangeDetails.NewPassword);

            if (res.Succeeded)
            {
                TempData["succesMsg"] = "Updated the profile";
                return RedirectToAction("Index","Profile");
            }

            var errors = string.Join("\n",res.Errors.Select(err => err.Description).ToList());
            ModelState.AddModelError("registerError", errors);
            ViewData["hasData"] = true;

            return View("Edit",model);
        }
    }
}
