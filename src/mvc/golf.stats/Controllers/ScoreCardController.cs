using Microsoft.AspNetCore.Mvc;

namespace golf.stats.Controllers
{
    public class ScoreCardController :Controller
    {
        public ScoreCardController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}