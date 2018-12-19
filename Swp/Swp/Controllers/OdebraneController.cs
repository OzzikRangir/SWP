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
    public class OdebraneController : Controller
    {
        private readonly SwpContext _context;

        public OdebraneController(SwpContext context)
        {
            _context = context;
        }

        // GET: Odebrane
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Detalewiadomosci.Include(d => d.IdwiadomosciNavigation).Include(d => d.IdzolnierzaNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Odebrane/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalewiadomosci = await _context.Detalewiadomosci
                .Include(d => d.IdwiadomosciNavigation)
                .Include(d => d.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (detalewiadomosci == null)
            {
                return NotFound();
            }

            return View(detalewiadomosci);
        }

        // GET: Odebrane/Create
        public IActionResult Create()
        {
            ViewData["Idwiadomosci"] = new SelectList(_context.Wiadomosc, "Idwiadomosci", "Idwiadomosci");
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza");
            return View();
        }

        // POST: Odebrane/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idwiadomosci,Idzolnierza,Dataotrzymania")] Detalewiadomosci detalewiadomosci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalewiadomosci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idwiadomosci"] = new SelectList(_context.Wiadomosc, "Idwiadomosci", "Idwiadomosci", detalewiadomosci.Idwiadomosci);
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", detalewiadomosci.Idzolnierza);
            return View(detalewiadomosci);
        }

        // GET: Odebrane/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalewiadomosci = await _context.Detalewiadomosci.FindAsync(id);
            if (detalewiadomosci == null)
            {
                return NotFound();
            }
            ViewData["Idwiadomosci"] = new SelectList(_context.Wiadomosc, "Idwiadomosci", "Idwiadomosci", detalewiadomosci.Idwiadomosci);
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", detalewiadomosci.Idzolnierza);
            return View(detalewiadomosci);
        }

        // POST: Odebrane/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idwiadomosci,Idzolnierza,Dataotrzymania")] Detalewiadomosci detalewiadomosci)
        {
            if (id != detalewiadomosci.Idwiadomosci)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalewiadomosci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalewiadomosciExists(detalewiadomosci.Idwiadomosci))
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
            ViewData["Idwiadomosci"] = new SelectList(_context.Wiadomosc, "Idwiadomosci", "Idwiadomosci", detalewiadomosci.Idwiadomosci);
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", detalewiadomosci.Idzolnierza);
            return View(detalewiadomosci);
        }

        // GET: Odebrane/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalewiadomosci = await _context.Detalewiadomosci
                .Include(d => d.IdwiadomosciNavigation)
                .Include(d => d.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (detalewiadomosci == null)
            {
                return NotFound();
            }

            return View(detalewiadomosci);
        }

        // POST: Odebrane/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalewiadomosci = await _context.Detalewiadomosci.FindAsync(id);
            _context.Detalewiadomosci.Remove(detalewiadomosci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalewiadomosciExists(int id)
        {
            return _context.Detalewiadomosci.Any(e => e.Idwiadomosci == id);
        }
    }
}
