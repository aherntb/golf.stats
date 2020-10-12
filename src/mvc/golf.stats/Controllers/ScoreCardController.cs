using Microsoft.AspNetCore.Mvc;
using golf.stats.Models;

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

        [HttpPost]
        public IActionResult PostStats(RoundStatsViewModel model)
        {
            if(!ModelState.IsValid)
            {
                //todo: this will need to change to do proper error handling
                return RedirectToAction("index");
            }
            return Ok();
        }
    }
}