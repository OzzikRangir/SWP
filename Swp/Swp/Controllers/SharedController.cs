using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swp.Model;

namespace Swp.Controllers
{
    public class SharedController : Controller
    {
        private readonly SwpContext _context;

        public SharedController(SwpContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Uzytkownik"] = _context.Uzytkownik;
            return View();
        }

        // GET: Shared
        public IActionResult _Layout()
        {
            return View();
        }

        // GET: Layout/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Layout/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Layout/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Layout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Layout/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Layout/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Layout/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}