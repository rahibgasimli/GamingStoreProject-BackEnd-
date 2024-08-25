using GamingStoreTekrar.Data;
using GamingStoreTekrar.Models;
using GamingStoreTekrar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamingStoreTekrar.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {
        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        [AllowAnonymous]
        public IActionResult Index(int page = 1)
        {
            ViewData["title"] = "Games";

            var games = _context.Games
                .Skip((page - 1) * 6)
                .Take(6)
                .Select(g => new GamesIndex()
                {
                    // MODEL == Databazaya
                    GameId = g.Id,
                    Name = g.Name,
                    PhotoUrl = g.PhotoPath,
                    Price = g.Price,
                    Genre = string.Join(",", g.Genres.Select(g => g.Name))
                }).ToList();

            //var chunks = games.Chunk(6).ToList();
            var totalGames = _context.Games.Count();
            int totalPages = (int)Math.Ceiling(totalGames / 6.0);

            if (page > totalPages || page <= 0)
            {
                ViewData["msg"] = "There isn't such page";
                return View("Error");
            }


            var genres = _context.Genres.ToList();


            //GamesIndexVm model = new()
            //{
            //    Games = chunks[page - 1].ToList(),
            //    CurrentPage = page,
            //    PageCount = chunks.Count,
            //    Genres = genres.Select(g => new GenreModel() { Id = g.Id, Name = g.Name }).ToList()
            //};

            GamesIndexVm model = new()
            {
                Games = games,
                CurrentPage = page,
                PageCount = totalPages,
                Genres = genres.Select(g => new GenreModel() { Id = g.Id, Name = g.Name }).ToList()
            };


            return View(model);
        }

        public IActionResult Single(string gameId)
        {
            Guid id;
            if (string.IsNullOrWhiteSpace(gameId) || !Guid.TryParse(gameId, out id))
            {
                ViewData["msg"] = "There isn't such game";
                return View("Error");
            }

            var game = _context.Games
                .Include(g => g.Genres)
                .Include(g => g.GameTags)
                .FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                ViewData["msg"] = "There isn`t such game";
                return View("Error");
            }



            var relatedGames = new List<RelatedGame>();

            foreach (var genre in game.Genres)
            {
                var gameQuery = _context.Games
                    .Where(g => g.Genres.Any(gnr => gnr.Name == genre.Name) && g != game)
                    .Select(g => new RelatedGame()
                    {
                        Id = g.Id.ToString(),
                        Genre = g.Genres.First(gnr => gnr.Name == genre.Name).Name,
                        PhotoPath = g.PhotoPath
                    })
                    .ToList();

                relatedGames.AddRange(gameQuery);
            }

            if (relatedGames.Count > 5)
            {
                var rnd = new Random();
                relatedGames = relatedGames.Skip(rnd.Next(0, relatedGames.Count)).Take(5).ToList();
                //relatedGames = relatedGames.Take(5).ToList();
            }


            game.ClickCount++;
            _context.SaveChanges();

            var vm = new GamesSingleVm()
            {
                GameDetails = new GamesSingleModel()
                {
                    gameId = game.Id.ToString(),
                    Name = game.Name,
                    ShortDesc = game.ShortDesc,
                    Description = game.Description,
                    Price = game.Price,
                    PhotoPath = game.PhotoPath,
                    Genres = string.Join("||", game.Genres.Select(g => g.Name)),
                    GameTags = string.Join("||", game.GameTags.Select(g => g.Name)),
                    ClickCount = game.ClickCount,
                },
                RelatedGames = relatedGames
            };


            return View(vm);
        }
        public IActionResult Filter(string genreFilter, int page = 1)
        {
            var pageSize = 3;

            var games = _context.Games.Include(g => g.Genres)
                .Where(g => g.Genres.Any(gnr => gnr.Name.ToLower().Contains(genreFilter)))
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new GamesIndex()
                {
                    GameId = x.Id,
                    Name = x.Name,
                    PhotoUrl = x.PhotoPath,
                    Price = x.Price,
                    Genre = string.Join(",", x.Genres.Select(g => g.Name.Replace(" ", "-")))
                }).ToList();

            var totalGames = _context.Games.Include(g => g.Genres)
                .Where(g => g.Genres.Any(gnr => gnr.Name.ToLower().Contains(genreFilter))).Count();
            int totalPages = (int)Math.Ceiling(totalGames / (double)pageSize);

            var vm = new GamesFilterVm()
            {
                Games = games,
                CurrentPage = page,
                PageCount = totalPages,
                CurrentFilter = genreFilter
            };

            return View(vm);
        }

    }
}
