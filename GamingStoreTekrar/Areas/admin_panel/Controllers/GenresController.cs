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
    public class GenresController : Controller
    {
        public GenresController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public async Task<IActionResult> AllGenres(int page = 1, int size = 5)
        {
            var genres = await _context.Genres
                .Skip((page - 1) * size)
                .Take(size)
                .Where(g => !g.IsDeleted)
                .Select(g => new AllGenresModel()
            {
                Id = g.Id.ToString(),
                Name = g.Name,
                CreatedDate = g.CreatedDate
            }).ToListAsync();

            var totalGenres = _context.Genres.Count();

            var vm = new GenresIndexVm()
            {
                CurrentPage = page,
                PageSize = size,
                TotalPage = (int)Math.Ceiling(totalGenres / (double)size),
                Genres = genres
            };

            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Delete(string genreId)
        {
            if(string.IsNullOrWhiteSpace(genreId) || !Guid.TryParse(genreId,out Guid id))
            {

                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "The given id isn't correct format" 
                };
                return View("Error",errorModel);
            }

            var genre = await _context.Genres.FindAsync(id);

            if(genre == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such genre"
                };
                return View("Error",errorModel);
            }

            //_context.Genres.Remove(genre);
            //await _context.SaveChangesAsync();

            genre.IsDeleted = true;
            await _context.SaveChangesAsync();

            return View("Index","Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGenreModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var genre = new Genre()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                CreatedDate = DateTime.UtcNow,
            };

            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();

            return RedirectToAction("AllGenres");
        }

    }
}
