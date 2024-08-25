using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Areas.admin_panel.ViewModels;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamingStoreTekrar.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class TagsController : Controller
    {
        public TagsController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public async Task<IActionResult> AllTags(int page = 1, int size = 5)
        {
            var tags = await _context.GameTags
                .Skip((page - 1) * size)
                .Take(size)
                .Select(t => new AllTagsModel()
                {
                    Id = t.Id.ToString(),
                    Name = t.Name,
                    CreatedDate = t.CreatedDate
                }).ToListAsync();

            var totalTags = _context.GameTags.Count();

            var vm = new TagsIndexVm()
            {
                CurrentPage = page,
                PageSize = size,
                TotalPage = (int)Math.Ceiling(totalTags / (double)size),
                Tags = tags
            };

            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTagModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var tag = new GameTag()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                CreatedDate = DateTime.UtcNow,
            };

            await _context.GameTags.AddAsync(tag);
            await _context.SaveChangesAsync();

            return RedirectToAction("AllTags");
        }
    }
}
