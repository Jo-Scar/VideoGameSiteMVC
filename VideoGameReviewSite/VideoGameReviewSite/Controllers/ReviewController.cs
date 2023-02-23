using Microsoft.AspNetCore.Mvc;

namespace VideoGameReviewSite.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
