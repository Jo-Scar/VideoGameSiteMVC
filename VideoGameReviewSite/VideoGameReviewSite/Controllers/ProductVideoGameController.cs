using Microsoft.AspNetCore.Mvc;
using VideoGameReviewSite.Data;
using VideoGameReviewSite.Models;

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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductVideoGameModel productVideoGame)
        {
            if (ModelState.IsValid)
            {
                _context.VideoGame.Add(productVideoGame);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productVideoGame);
        }
        public ActionResult Delete(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var game = _context.VideoGame.FirstOrDefault(
                g => g.Id == id);
            if(game == null)
            {
                return NotFound();
            }
            return View(game);
        }
        [HttpPost]
        public ActionResult Delete(int? id, bool notUsed)
        {
            if (_context.VideoGame == null)
            {
                return Problem("Entity set 'VideoGameContext.VideoGame is null");
            }
            var productVideoGame = _context.VideoGame.Find(id);
            _context.VideoGame.Remove(productVideoGame);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, ProductVideoGameModel productVideoGame)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(productVideoGame).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productVideoGame);
        }
        public ActionResult Details(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var productVideoGame = _context.VideoGame.Find(id);
            return View(productVideoGame);
        }
    }
}
