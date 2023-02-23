using Microsoft.AspNetCore.Mvc;

namespace VideoGameReviewSite.Controllers
{
    public class VideoGameReviewSiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
