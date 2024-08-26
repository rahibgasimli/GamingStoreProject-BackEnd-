using GamingStoreTekrar.Areas.admin_panel.Models;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Models;
using GamingStoreTekrar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Security.Claims;

namespace GamingStoreTekrar.Controllers
{
    public class GamesController : Controller
    {
        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public IActionResult Index(int page = 1)
        {
            ViewData["title"] = "Games";

            var games = _context.Games
                .Skip((page - 1) * 6)
                .Take(6)
                .Where(g => !g.IsDeleted)
                .Select(g => new GamesIndex()
                {
                    // MODEL == Databazaya
                    GameId = g.Id,
                    Name = g.Name,
                    PhotoUrl = g.PhotoPath,
                    Price = g.Price,
                    Genre = string.Join(",", g.Genres.Where(gnr => !gnr.IsDeleted).Select(g => g.Name)),
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
                .Include(g => g.Reviews)
                .ThenInclude(review => review.User)
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
                        PhotoPath = g.PhotoPath,
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
                    Reviews = game.Reviews
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> AddReview(string reviewText,string gameId)
        {
            if (string.IsNullOrWhiteSpace(reviewText) || string.IsNullOrWhiteSpace(gameId) || !Guid.TryParse(gameId,out Guid id))
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "The given text or id is empty"
                };
                return View("Error",errorModel);
            }

            var game = await _context.Games
                .Include(g => g.Reviews)
                .FirstOrDefaultAsync(g => g.Id == id);

            var usrId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if(game == null || usrId == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such game or you must login"
                };
                return View("Error",errorModel);
            }

            var usr = _context.Users.Find(usrId.Value);

            if(usr == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There were some errors"
                };
                return View("Error", errorModel);
            }

            var review = new Review()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.UtcNow,
                ReviewText = reviewText,
                User = usr,
                Game = game
            };

            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();


            return RedirectToAction("Single", new { gameId = gameId});
        }

    }
}
