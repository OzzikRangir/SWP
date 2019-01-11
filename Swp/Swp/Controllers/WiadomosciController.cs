using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Swp.Model;

namespace Swp.Controllers
{
    public class WiadomosciController : Controller
    {
        private readonly SwpContext _context;

        public WiadomosciController(SwpContext context)
        {
            _context = context;
        }

        // GET: Wiadomosci
        public async Task<IActionResult> Index()
        {
            System.Console.WriteLine(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
            System.Console.WriteLine(User.FindFirst(System.Security.Claims.ClaimTypes.Role).Value);
            var swpContext = _context.Wiadomosc.Include(w => w.IdzolnierzaNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Wiadomosci/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosc = await _context.Wiadomosc
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (wiadomosc == null)
            {
                return NotFound();
            }

            return View(wiadomosc);
        }

        // GET: Wiadomosci/Create
        public IActionResult Create()
        {
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza");
            return View();
        }

        // POST: Wiadomosci/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idwiadomosci,Idzolnierza,Tytul,Tresc")] Wiadomosc wiadomosc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wiadomosc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Id", wiadomosc.Idzolnierza);
            return View(wiadomosc);
        }

        // GET: Wiadomosci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosc = await _context.Wiadomosc.FindAsync(id);
            if (wiadomosc == null)
            {
                return NotFound();
            }
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wiadomosc.Idzolnierza);
            return View(wiadomosc);
        }

        // POST: Wiadomosci/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idwiadomosci,Idzolnierza,Tytul,Tresc")] Wiadomosc wiadomosc)
        {
            if (id != wiadomosc.Idwiadomosci)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wiadomosc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WiadomoscExists(wiadomosc.Idwiadomosci))
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
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "Idzolnierza", wiadomosc.Idzolnierza);
            return View(wiadomosc);
        }

        // GET: Wiadomosci/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosc = await _context.Wiadomosc
                .Include(w => w.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (wiadomosc == null)
            {
                return NotFound();
            }

            return View(wiadomosc);
        }

        // POST: Wiadomosci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wiadomosc = await _context.Wiadomosc.FindAsync(id);
            _context.Wiadomosc.Remove(wiadomosc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WiadomoscExists(int id)
        {
            return _context.Wiadomosc.Any(e => e.Idwiadomosci == id);
        }
    }
}
