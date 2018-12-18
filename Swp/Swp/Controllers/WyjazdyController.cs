using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Swp.Model;

namespace Swp.Controllers
{
    public class WyjazdyController : Controller
    {
        private readonly SwpContext _context;

        public WyjazdyController(SwpContext context)
        {
            _context = context;
        }

        // GET: Wyjazdy
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Wyjazd.Include(w => w.IdzolnierzaNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Wyjazdy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjazd = await _context.Wyjazd
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwyjazdu == id);
            if (wyjazd == null)
            {
                return NotFound();
            }

            return View(wyjazd);
        }

        // GET: Wyjazdy/Create
        public IActionResult Create()
        {
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza");
            return View();
        }

        // POST: Wyjazdy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idwyjazdu,Idzolnierza,RodzajWyjazdu,Datawyjazdu")] Wyjazd wyjazd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wyjazd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wyjazd.Idzolnierza);
            return View(wyjazd);
        }

        // GET: Wyjazdy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjazd = await _context.Wyjazd.FindAsync(id);
            if (wyjazd == null)
            {
                return NotFound();
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wyjazd.Idzolnierza);
            return View(wyjazd);
        }

        // POST: Wyjazdy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idwyjazdu,Idzolnierza,RodzajWyjazdu,Datawyjazdu")] Wyjazd wyjazd)
        {
            if (id != wyjazd.Idwyjazdu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wyjazd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WyjazdExists(wyjazd.Idwyjazdu))
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
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wyjazd.Idzolnierza);
            return View(wyjazd);
        }

        // GET: Wyjazdy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjazd = await _context.Wyjazd
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwyjazdu == id);
            if (wyjazd == null)
            {
                return NotFound();
            }

            return View(wyjazd);
        }

        // POST: Wyjazdy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wyjazd = await _context.Wyjazd.FindAsync(id);
            _context.Wyjazd.Remove(wyjazd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WyjazdExists(int id)
        {
            return _context.Wyjazd.Any(e => e.Idwyjazdu == id);
        }
    }
}
