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
    public class WyjsciaController : Controller
    {
        private readonly SwpContext _context;

        public WyjsciaController(SwpContext context)
        {
            _context = context;
        }

        // GET: Wyjscia
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Wyjscie.Include(w => w.IdzolnierzaNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Wyjscia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjscie = await _context.Wyjscie
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwyjscia == id);
            if (wyjscie == null)
            {
                return NotFound();
            }

            return View(wyjscie);
        }

        // GET: Wyjscia/Create
        public IActionResult Create()
        {
            ViewData["RodzajWyjscia"] = new SelectList(Enumerations.WyjsciaSlownik, "Key", "Value");
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View();
        }

        // POST: Wyjscia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idzolnierza,RodzajWyjscia,Datawyjscia")] Wyjscie wyjscie)
        {

            wyjscie.Datawyjscia = DateTime.Now;
            System.Console.WriteLine(wyjscie.Datawyjscia);
            if (ModelState.IsValid)
            {
                _context.Add(wyjscie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RodzajWyjscia"] = new SelectList(Enumerations.WyjsciaSlownik, "Key", "Value");
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View(wyjscie);
        }

        // GET: Wyjscia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjscie = await _context.Wyjscie.FindAsync(id);
            if (wyjscie == null)
            {
                return NotFound();
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wyjscie.Idzolnierza);
            return View(wyjscie);
        }

        public async Task<IActionResult> Powrot(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjscie = await _context.Wyjscie.FindAsync(id);
            wyjscie.Datapowrotu = DateTime.Now;


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wyjscie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WyjscieExists(wyjscie.Idwyjscia))
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
            if (wyjscie == null)
            {
                return NotFound();
            }
            return View(wyjscie);
        }

        // POST: Wyjscia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idwyjscia,Idzolnierza,RodzajWyjscia")] Wyjscie wyjscie)
        {
            if (id != wyjscie.Idwyjscia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wyjscie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WyjscieExists(wyjscie.Idwyjscia))
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
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wyjscie.Idzolnierza);
            return View(wyjscie);
        }

        // GET: Wyjscia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wyjscie = await _context.Wyjscie
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwyjscia == id);
            if (wyjscie == null)
            {
                return NotFound();
            }

            return View(wyjscie);
        }

        // POST: Wyjscia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wyjscie = await _context.Wyjscie.FindAsync(id);
            _context.Wyjscie.Remove(wyjscie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WyjscieExists(int id)
        {
            return _context.Wyjscie.Any(e => e.Idwyjscia == id);
        }
    }
}
