using Microsoft.AspNetCore.Mvc;
using SimpleWebAPP.Data;
using SimpleWebAPP.Models;

namespace SimpleWebAPP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        // I right clicked Index and clicked add view
        // to create an Index Html page for category
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories; //.toList() ;
  
            return View(objCategoryList);
        }

        // Used for the button to show the view of Create page
        // GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }


    }
}
