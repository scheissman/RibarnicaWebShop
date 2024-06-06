using Microsoft.AspNetCore.Mvc;
using Ribarnica.Data;
using Ribarnica.Models;

namespace Ribarnica.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext      _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {   
            var objCategory = _context.Categories.ToList();
            return View();
        }
    }
}
