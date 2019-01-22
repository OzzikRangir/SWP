using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Swp.Model;

namespace Swp.Controllers
{
    public class UzytkownicyController : Controller
    {
        private readonly SwpContext _context;
        public UzytkownicyController(SwpContext context)
        {
            _context = context;
           
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewData["Logged"] = _context.Uzytkownik.Include(a => a.IdroliNavigation);
            ViewData["Soldiers"] = _context.Zolnierz.Include(a => a.IduzytkownikaNavigation);
        }

        // GET: Uzytkownicy
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Uzytkownik.Include(u => u.Zolnierz).Include(r => r.IdroliNavigation);

            ViewData["Roles"] = _context.Uzytkownik.Include(z => z.IdroliNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Uzytkownicy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uzytkownik = await _context.Uzytkownik
                .FirstOrDefaultAsync(m => m.Iduzytkownika == id);
            if (uzytkownik == null)
            {
                return NotFound();
            }

            return View(uzytkownik);
        }

        // GET: Uzytkownicy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Uzytkownicy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Iduzytkownika,Login")] Uzytkownik uzytkownik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uzytkownik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uzytkownik);
        }

        // GET: Uzytkownicy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var uzytkownik = await _context.Uzytkownik.FindAsync(id);
            ViewData["Rola"] = new SelectList(_context.Rola, "Idroli", "Nazwa", uzytkownik.Idroli);
            
            if (uzytkownik == null)
            {
                return NotFound();
            }
            return View(uzytkownik);
        }

        // POST: Uzytkownicy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Iduzytkownika,Idroli,Haslo,Login,Zolnierz")] Uzytkownik uzytkownik)
        {
            ViewData["Rola"] = new SelectList(_context.Rola, "Idroli", "Nazwa", uzytkownik.Idroli);
            
            if (id != uzytkownik.Iduzytkownika)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uzytkownik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UzytkownikExists(uzytkownik.Iduzytkownika))
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

            return View(uzytkownik);
        }

        // GET: Uzytkownicy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uzytkownik = await _context.Uzytkownik
                .FirstOrDefaultAsync(m => m.Iduzytkownika == id);
            if (uzytkownik == null)
            {
                return NotFound();
            }

            return View(uzytkownik);
        }

        // POST: Uzytkownicy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uzytkownik = await _context.Uzytkownik.FindAsync(id);

            _context.Uzytkownik.Remove(uzytkownik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UzytkownikExists(int id)
        {
            return _context.Uzytkownik.Any(e => e.Iduzytkownika == id);
        }
    }
}
