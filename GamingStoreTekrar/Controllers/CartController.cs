using GamingStoreTekrar.Data;
using GamingStoreTekrar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SessionMapper;

namespace GamingStoreTekrar.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        public CartController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public IActionResult Index()
        {
            var items = HttpContext.Session.Get<List<CartIndex>>("cartItems") ?? new List<CartIndex>();


            return View(items);
        }


        public async Task<IActionResult> AddGame(Guid gameId)
        {
            var game = await _context.Games
                        .Include(g => g.GameTags)
                        .Include(g => g.Genres)
                        .FirstOrDefaultAsync(g => g.Id == gameId);

            if (game == null)
            {
                ViewData["msg"] = "There isn't such game";
                return View("Error");
            }

            var cartGame = new CartIndex()
            {
                GameId = gameId,
                Name = game.Name,
                PhotoUrl = game.PhotoPath,
                Price = game.Price,
                Genre = string.Join(", ", game.Genres.Select(gnr => gnr.Name)),
                GameTag = string.Join(", ", game.GameTags.Select(tag => tag.Name))
            };

            var items = HttpContext.Session.Get<List<CartIndex>>("cartItems");

            if (items == null)
            {
                items = new List<CartIndex>() { cartGame };
            }
            else
            {
                items.Add(cartGame);
            }

            HttpContext.Session.SetAsJson<List<CartIndex>>("cartItems", items);

            return View("Index", items);
        }
    }
}
