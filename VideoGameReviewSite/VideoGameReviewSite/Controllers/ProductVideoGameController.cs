using Microsoft.AspNetCore.Mvc;

namespace VideoGameReviewSite.Controllers
{
    public class ProductVideoGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
