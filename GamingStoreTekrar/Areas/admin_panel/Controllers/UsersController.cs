using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Areas.admin_panel.ViewModels;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Dtos;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Enums;
using GamingStoreTekrar.Extensions;
using GamingStoreTekrar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace GamingStoreTekrar.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class UsersController : Controller
    {
        public UsersController(AppDbContext appDbContext, UserManager<AppUser> userManeger, IStorageService storageService, RoleManager<IdentityRole> roleManager, IEmailService emailService)
        {
            _context = appDbContext;
            _userManeger = userManeger;
            _storageService = storageService;
            _roleManager = roleManager;
            _emailService = emailService;
        }

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManeger;
        private readonly IStorageService _storageService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;

        public async Task<IActionResult> AllUsers(int page = 1, int pageSize = 5)
        {

            var users = await _context.Users
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(u => new AllUsersModel()
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    FullName = $"{u.FName} {u.LName}",
                    Email = u.Email,
                    Age = u.Age,
                    ProfilePhoto = u.ProfilePhoto
                }).ToListAsync();


            int totalUsers = _context.Users.Count();

            var vm = new UsersIndexVm()
            {
                Users = users,
                CurrentPage = page,
                TotalPage = (int)Math.Ceiling(totalUsers / (double)pageSize),
                PageSize = pageSize
            };

            return View(vm);
        }

        public async Task<IActionResult> Edit(string userId)
        {
            var usr = await _userManeger.FindByIdAsync(userId);

            if (usr == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };
                return View("Error", errorModel);
            }

            var editDetails = new EditUserModel()
            {
                Id = usr.Id,
                UserName = usr.UserName,
                FirstName = usr.FName,
                LastName = usr.LName,
                Email = usr.Email,
                Age = usr.Age,
                PhotoPath = usr.ProfilePhoto
            };

            return View(editDetails);
        }
        public async Task<IActionResult> ChangeRole(string userId)
        {
            var usr = await _userManeger.FindByIdAsync(userId);

            if(usr == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error",errorModel);
            }

            var currentRoles = await _userManeger.GetRolesAsync(usr);

            var roles = await _context.Roles.ToListAsync();
            var roleModel = new ChangeRoleModel()
            {
                Id = usr.Id,
                Email = usr.Email,
                PhotoPath = usr.ProfilePhoto,
                UserName = usr.UserName,
                UserRoles = currentRoles.ToList(),
                Roles = roles,
            };

            return View(roleModel);  
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> SendBatchEmail()
        {
            var users = await _userManeger.Users.OrderBy(u => u.FName + " " + u.LName).ToListAsync();

            ViewBag.Users = users;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendBatchEmail(SendBatchEmailModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            foreach (var mail in model.Emails)
            {
                var dto = new MailDto()
                {
                    Addresses = new List<MailboxAddress>() { new MailboxAddress(mail.Split("@")[0],mail)},
                    Subject = model.Subject,
                    Content = model.Message
                };
                await _emailService.SendAsync(dto);
            }

            

            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usr = await _userManeger.FindByIdAsync(model.Id);

            if (usr == null)
            {
                ModelState.AddModelError("editError", "There isn't such user with this id");
                return View(model);
            }

            usr.UserName = model.UserName;
            usr.FName = model.FirstName;
            usr.LName = model.LastName;
            usr.Email = model.Email;
            usr.Age = model.Age;

            if (model.ProfilePhoto != null)
            {
                var dto = await _storageService.UploadFileAsync("profile-photos", model.ProfilePhoto);
                if (_storageService is LocalStorageService)
                {
                    dto.FullPath = $"uploads/{dto.FullPath}";
                }
                usr.ProfilePhoto = dto.FullPath;
            }

            var res = await _userManeger.UpdateAsync(usr);

            if (!res.Succeeded)
            {
                ModelState.AddModelError("editError", res.Errors.ErrorsToString());
                return View(model);
            }

            return RedirectToAction("AllUsers");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(ChangeRoleModel model)
        {
            var usr = await _userManeger.FindByIdAsync(model.Id);

            if(usr == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error",errorModel);
            }

            var role = await _roleManager.FindByIdAsync(model.SelectedRoleId);
            if(role == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such role"
                };

                return View("Error", errorModel);
            }

            if(await _userManeger.IsInRoleAsync(usr, role.Name))
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There user already has this role"
                };

                return View("Error", errorModel);
            }

            var res = await _userManeger.AddToRoleAsync(usr,role.Name);

            if (!res.Succeeded)
            {
                ModelState.AddModelError("roleError",res.Errors.ErrorsToString());
                return View(model);
            }

            return RedirectToAction("AllUsers");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string Id)
        {
            if(string.IsNullOrWhiteSpace(Id))
            {
                var errorModel = new ErrorModel();
                errorModel.ErrorMessage = "The given Id is incorrect";
                return View("Error",errorModel);
            }

            var usr = await _userManeger.FindByIdAsync(Id);

            if(usr == null)
            {
                var errorModel = new ErrorModel();
                errorModel.ErrorMessage = "There isn't such user";
                return View("Error",errorModel);
            }

            var res = await _userManeger.DeleteAsync(usr);

            if (!res.Succeeded)
            {
                var errorModel = new ErrorModel();
                errorModel.ErrorMessage = res.Errors.ErrorsToString();
                return View("Error",errorModel);
            }

            return RedirectToAction("AllUsers");
        }


    }
}
