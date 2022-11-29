using Microsoft.AspNetCore.Mvc;
using tutorial.Pages.Data;
using tutorial.Pages.Shared;

namespace tutorial.Pages
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Category> objcategorylist = _db.categories;
            return View(objcategorylist);
        }

        public IActionResult Create()
        {
            
            return View();
        }

    }
}
