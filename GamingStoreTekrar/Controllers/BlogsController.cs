using Microsoft.AspNetCore.Mvc;

namespace GamingStoreTekrar.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }
    }
}
