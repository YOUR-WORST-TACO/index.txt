using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Index.txt.Models;

namespace Index.txt.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoModelDbContext _context;

        public HomeController(TodoModelDbContext context)
        {
            _context = context;
            
            var contexts = new[]
                
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}