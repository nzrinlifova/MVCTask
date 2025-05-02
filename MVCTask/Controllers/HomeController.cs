using Microsoft.AspNetCore.Mvc;
using MVCTask.Context;
using MVCTask.Models;

namespace MVCTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          //  List<HealthCareSolution>healthCareSolution=_context.HealthCareSolutions.ToList();
            return View(/*healthCareSolution*/);
        }
    }
}
