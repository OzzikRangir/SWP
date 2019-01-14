using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewData["Logged"] = _context.Uzytkownik.Include(a => a.IdroliNavigation);
            ViewData["Soldiers"] = _context.Zolnierz.Include(a => a.IduzytkownikaNavigation);
        }


        // GET: Wiadomosci
        public async Task<IActionResult> Index()
        { 
            return View();
        }

        // GET: Wiadomosci/Wyslane
        public async Task<IActionResult> Wyslane()
        {
            var swpContext = _context.Wiadomosc.Include(w => w.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci)
                .Where(m => m.IdzolnierzaNavigation.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value)
                .OrderByDescending(c => c.Detalewiadomosci.Dataotrzymania);
            return View(await swpContext.ToListAsync());
        }

        // GET: Wiadomosci/Odebrane
        public async Task<IActionResult> Odebrane()
        {
            var swpContext = _context.Wiadomosc.Include(w => w.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci)
                .Where(m => m.Detalewiadomosci.IdzolnierzaNavigation.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value)
                .OrderByDescending(c => c.Detalewiadomosci.Dataotrzymania);
            return View(await swpContext.ToListAsync());
        }

        // GET: Wiadomosci/Odebrana/5
        public async Task<IActionResult> Odebrana(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosc = await _context.Wiadomosc
                .Include(w => w.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (wiadomosc == null)
            {
                return NotFound();
            }

            return View(wiadomosc);
        }
        // GET: Wiadomosci/Wyslana/5
        public async Task<IActionResult> Wyslana(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wiadomosc = await _context.Wiadomosc
                .Include(w => w.IdzolnierzaNavigation)
                .Include(w => w.Detalewiadomosci.IdzolnierzaNavigation)
                .FirstOrDefaultAsync(m => m.Idwiadomosci == id);
            if (wiadomosc == null)
            {
                return NotFound();
            }

            return View(wiadomosc);
        }

        // GET: Wiadomosci/Utworz
        public IActionResult Utworz()
        {
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName");
            return View();
        }

        // POST: Wiadomosci/Utworz
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Utworz([Bind("Idwiadomosci,Tytul,Tresc")] Wiadomosc wiadomosc, [Bind("Idwiadomosci,Idzolnierza")] Detalewiadomosci detalewiadomosci)
        {
            ViewData["Idzolnierza"] = new SelectList(_context.Zolnierz, "Idzolnierza", "FullName", wiadomosc.Idzolnierza);
            if (ModelState.IsValid)
            {
                wiadomosc.Idzolnierza = _context.Zolnierz.Where(u => u.Iduzytkownika.ToString() == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).FirstOrDefault().Idzolnierza;
                _context.Add(wiadomosc);
                detalewiadomosci.Idwiadomosci = wiadomosc.Idwiadomosci;
                detalewiadomosci.Dataotrzymania = DateTime.Now;
                _context.Add(detalewiadomosci);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(wiadomosc);
        }

        // POST: Wiadomosci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var wiadomosc = await _context.Wiadomosc.FindAsync(id);
            var detale = await _context.Detalewiadomosci.FindAsync(id);
            _context.Detalewiadomosci.Remove(detale);
            _context.Wiadomosc.Remove(wiadomosc);
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Odebrane));
        }

        private bool WiadomoscExists(int id)
        {
            return _context.Wiadomosc.Any(e => e.Idwiadomosci == id);
        }
    }
}
