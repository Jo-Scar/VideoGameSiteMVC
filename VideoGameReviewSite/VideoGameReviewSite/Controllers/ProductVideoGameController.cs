using Microsoft.AspNetCore.Mvc;
using VideoGameReviewSite.Data;

namespace VideoGameReviewSite.Controllers
{
    public class ProductVideoGameController : Controller
    {
        private readonly VideoGameContext _context;
        public ProductVideoGameController(VideoGameContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View(_context.VideoGame.ToList());
        }
    }
}
