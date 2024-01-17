using Microsoft.AspNetCore.Mvc;
using ProjektnaASP.Data;

namespace ProjektnaASP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext  db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objCategoryList =  _db.Categories.ToList();
            return View();
        }
    }
}
