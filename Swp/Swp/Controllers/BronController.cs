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
    public class BronController : Controller
    {
        private readonly SwpContext _context;

        public BronController(SwpContext context)
        {
            _context = context;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewData["Logged"] = _context.Uzytkownik.Include(a => a.IdroliNavigation);
            ViewData["Soldiers"] = _context.Zolnierz.Include(a => a.IduzytkownikaNavigation);
        }

        // GET: Bron

     
        public async Task<IActionResult> Index()
        {
            if (_context.Uzytkownik.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Administrator" ||
                _context.Uzytkownik.Where(z => z.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(a => a.IdroliNavigation.Nazwa).FirstOrDefault() == "Sluzba") { 
            var swpContext = _context.Bron.Include(b => b.IdzolnierzaNavigation);
                return View(await swpContext.ToListAsync());
            }
        else{
        var swpContext = _context.Bron.Include(b => b.IdzolnierzaNavigation).Where(b => b.IdzolnierzaNavigation.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
                return View(await swpContext.ToListAsync());
            }
        }

        // GET: Bron/Details/5
      
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bron = await _context.Bron
                .Include(b => b.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idbroni == id);
            if (bron == null)
            {
                return NotFound();
            }

            return View(bron);
        }

        // GET: Bron/Create
        public IActionResult Create()
        {
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View();
        }

        // POST: Bron/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idbroni,Idzolnierza,Nazwabroni,StanBroni")] Bron bron)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bron);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View(bron);
        }

        // GET: Bron/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bron = await _context.Bron.FindAsync(id);
            if (bron == null)
            {
                return NotFound();
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName", bron.Idzolnierza);
            return View(bron);
        }

        // POST: Bron/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Idbroni,Idzolnierza,Nazwabroni,StanBroni")] Bron bron)
        {
            if (id != bron.Idbroni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bron);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronExists(bron.Idbroni))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", bron.Idzolnierza);
            return View(bron);
        }

        // GET: Bron/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bron = await _context.Bron
                .Include(b => b.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idbroni == id);
            if (bron == null)
            {
                return NotFound();
            }

            return View(bron);
        }

        // POST: Bron/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bron = await _context.Bron.FindAsync(id);
            _context.Bron.Remove(bron);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronExists(string id)
        {
            return _context.Bron.Any(e => e.Idbroni == id);
        }
    }
}
