using GamingStoreTekrar.Data;
using GamingStoreTekrar.Models;
using GamingStoreTekrar.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreTekrar.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public IActionResult Index()
        {
            var trendingGames = _context.Games
                .OrderByDescending(g => g.ClickCount)
                .Take(4)
                .Select(g => new GamesIndex()
                {
                    GameId = g.Id,
                    Name = g.Name,
                    PhotoUrl = g.PhotoPath,
                    Price = g.Price,
                    Genre = string.Join(", ", g.Genres.Select(genre => genre.Name).ToList())
                }).ToList();



            var topGenres = _context.Genres
                .OrderByDescending(gnr => gnr.Games.Count)
                .Take(5)
                .Select(gnr => gnr.Name).ToList();

            var vm = new HomeIndexVm()
            {
                TrendingGames = trendingGames,
                TopGenres = topGenres
            };

            return View(vm);
        }


        public IActionResult Search(string query, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                ViewData["msg"] = "Query can't be empty";
                return View("Error");
            }

            int size = 12;

            var games = _context.Games
                .Skip((page - 1) * size)
                .Take(size)
                .Where(g => g.Name.ToLower().Contains(query.ToLower()) ||
                                                   g.Description.ToLower().Contains(query.ToLower()) ||
                                                   g.Genres.Any(gnr => gnr.Name.ToLower().Contains(query.ToLower())) ||
                                                   g.GameTags.Any(tag => tag.Name.ToLower().Contains(query.ToLower()))
                                                   )
                .Select(g => new GamesIndex()
                {
                    GameId = g.Id,
                    Name = g.Name,
                    PhotoUrl = g.PhotoPath,
                    Price = g.Price,
                    Genre = string.Join(", ", g.Genres.Select(genre => genre.Name).ToList())
                }).ToList();


            var totalFound = _context.Games.Where(g => g.Name.ToLower().Contains(query.ToLower()) ||
                                                   g.Description.ToLower().Contains(query.ToLower()) ||
                                                   g.Genres.Any(gnr => gnr.Name.ToLower().Contains(query.ToLower())) ||
                                                   g.GameTags.Any(tag => tag.Name.ToLower().Contains(query.ToLower()))
                                                   ).Count();

            var sm = new SearchModel()
            {
                FoundGames = games,
                CurrentPage = page,
                PageCount = (int)Math.Ceiling(totalFound / (double)size),
                Query = query
            };


            return View(sm);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
