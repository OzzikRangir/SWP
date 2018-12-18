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
    public class ZolnierzController : Controller
    {
        private readonly SwpContext _context;

        public ZolnierzController(SwpContext context)
        {
            _context = context;
        }

        // GET: Zolnierz
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Zolnierz.Include(z => z.IdgrupyNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Zolnierz/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zolnierz = await _context.Zolnierz
                .Include(z => z.IdgrupyNavigation)
                .FirstOrDefaultAsync(m => m.Idzolnierza == id);
            if (zolnierz == null)
            {
                return NotFound();
            }

            return View(zolnierz);
        }

        // GET: Zolnierz/Create
        public IActionResult Create()
        {
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy");
            return View();
        }

        // POST: Zolnierz/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idzolnierza,Idgrupy,Stopien,Imie,Naziwsko,Adres,Imieojca,Imiematki,Pesel,Numertelefonu")] Zolnierz zolnierz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zolnierz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zolnierz.Idgrupy);
            return View(zolnierz);
        }

        // GET: Zolnierz/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zolnierz = await _context.Zolnierz.FindAsync(id);
            if (zolnierz == null)
            {
                return NotFound();
            }
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zolnierz.Idgrupy);
            return View(zolnierz);
        }

        // POST: Zolnierz/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idzolnierza,Idgrupy,Stopien,Imie,Naziwsko,Adres,Imieojca,Imiematki,Pesel,Numertelefonu")] Zolnierz zolnierz)
        {
            if (id != zolnierz.Idzolnierza)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zolnierz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZolnierzExists(zolnierz.Idzolnierza))
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
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zolnierz.Idgrupy);
            return View(zolnierz);
        }

        // GET: Zolnierz/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zolnierz = await _context.Zolnierz
                .Include(z => z.IdgrupyNavigation)
                .FirstOrDefaultAsync(m => m.Idzolnierza == id);
            if (zolnierz == null)
            {
                return NotFound();
            }

            return View(zolnierz);
        }

        // POST: Zolnierz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zolnierz = await _context.Zolnierz.FindAsync(id);
            _context.Zolnierz.Remove(zolnierz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZolnierzExists(int id)
        {
            return _context.Zolnierz.Any(e => e.Idzolnierza == id);
        }
    }
}
