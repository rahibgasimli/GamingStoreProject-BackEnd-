using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Enums;
using GamingStoreTekrar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamingStoreTekrar.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class GamesController : Controller
    {
        public GamesController(IStorageService storageService, AppDbContext context)
        {
            _storageService = storageService;
            _context = context;
        }

        private readonly IStorageService _storageService;
        private readonly AppDbContext _context;


        public async Task<IActionResult> Create()
        {
            var genres = await _context.Genres.ToListAsync();
            var tags = await _context.GameTags.ToListAsync();

            ViewData["genres"] = genres;
            ViewData["tags"] = tags;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var dto = await _storageService.UploadFileAsync("game-photos", model.GameImage);

            if (_storageService is LocalStorageService)
            {
                dto.FullPath = $"uploads/{dto.FullPath}";
            }


            var selecetedGenres = await _context.Genres
                .Where(g => model.Genres.Contains(g.Id.ToString()))
                .ToListAsync();

            var selecetedTags = await _context.GameTags
                .Where(t => model.Tags.Contains(t.Id.ToString()))
                .ToListAsync();

            var game = new Game()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ShortDesc = model.ShortDesc,
                Description = model.Description,
                ClickCount = 0,
                IsDeleted = false,
                Price = model.Price,
                PhotoPath = dto.FullPath,
                CreatedDate = DateTime.UtcNow,
                Genres = selecetedGenres,
                GameTags = selecetedTags
            };

            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
