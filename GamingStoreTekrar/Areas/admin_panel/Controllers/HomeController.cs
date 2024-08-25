using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Dtos;
using GamingStoreTekrar.Enums;
using GamingStoreTekrar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace GamingStoreTekrar.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class HomeController : Controller
    {
        public HomeController(IEmailService emailService, AppDbContext context)
        {
            _emailService = emailService;
            _context = context;
        }

        private readonly IEmailService _emailService;
        private readonly AppDbContext _context;

        public IActionResult Index()
        {
            ViewBag.totalUsers = _context.Users.Count();
            ViewBag.totalGames = _context.Games.Where(g => !g.IsDeleted).Count();
            ViewBag.totalViews = _context.Games.Where(g => !g.IsDeleted).Sum(g => g.ClickCount);
            ViewBag.totalGenres = _context.Genres.Where(gnr => !gnr.IsDeleted).Count();
            ViewBag.totalTags = _context.GameTags.Where(t => !t.IsDeleted).Count();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMail(EmailModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",model);
            }

            var dto = new MailDto()
            {
                Addresses = new List<MailboxAddress>() 
                {
                    new MailboxAddress("receiver",model.Recepient)
                },
                Subject = model.Subject,
                Content = model.Message
            };

            await _emailService.SendAsync(dto);

            return RedirectToAction("Index");
        }
    }
}
