using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swp.Model;
using Swp.Models;

namespace Swp.Controllers
{
    public class HomeController : Controller
    {

        private readonly SwpContext _context;

        public HomeController(SwpContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            ViewData["Uzytkownik"] = _context.Uzytkownik.Include(a => a.IdroliNavigation);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
