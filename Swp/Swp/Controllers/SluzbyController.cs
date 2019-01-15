using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Swp.Model;

namespace Swp.Controllers
{
    public class SluzbyController : Controller
    {
        private readonly SwpContext _context;

        public SluzbyController(SwpContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewData["Logged"] = _context.Uzytkownik.Include(a => a.IdroliNavigation);
            
            ViewData["Soldiers"] = _context.Zolnierz.Include(a => a.IduzytkownikaNavigation);
        }

        // GET: Sluzby
        public async Task<IActionResult> Index(int? id)
        {
            ViewData["Month"] = id;
            if (id == null)
            {
                ViewData["Month"] = DateTime.Now.Month;
            }
            
            var swpContext = _context.Sluzba.Include(a => a.IdzolnierzaNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Sluzby/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sluzba = await _context.Sluzba
                .Include(s => s.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idsluzby == id);
            if (sluzba == null)
            {
                return NotFound();
            }

            return View(sluzba);
        }

        // GET: Sluzby/Create
        public IActionResult Create()
        {
            ViewData["Sluzby"] = _context.Sluzba.Include(a => a.IdzolnierzaNavigation);
            ViewData["Rodzaje"] = new SelectList(Enumerations.SluzbySlownik, "Key", "Value");
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View();
        }

        // POST: Sluzby/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idzolnierza,Datasluzby,Rodzajsluzby")] Sluzba sluzba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sluzba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", sluzba.Idzolnierza);
            return View(sluzba);
        }


        // GET: Sluzby/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sluzba = await _context.Sluzba
                .Include(s => s.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idsluzby == id);
            if (sluzba == null)
            {
                return NotFound();
            }

            return View(sluzba);
        }

        // POST: Sluzby/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sluzba = await _context.Sluzba.FindAsync(id);
            _context.Sluzba.Remove(sluzba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SluzbaExists(int id)
        {
            return _context.Sluzba.Any(e => e.Idsluzby == id);
        }
    }
}
