using eproject_prep2.Data;
using eproject_prep2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eproject_prep2.Controllers
{
    public class HomeController : Controller
    {
        readonly eproject_prep2Context _context;
        public HomeController(eproject_prep2Context db)
        {
            _context =db ;
        }
        public IActionResult Index()

        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
