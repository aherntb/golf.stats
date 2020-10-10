using Microsoft.AspNetCore.Mvc;

namespace golf.stats.Controllers
{
    public class CompetitionsController : Controller
    {
        public CompetitionsController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}