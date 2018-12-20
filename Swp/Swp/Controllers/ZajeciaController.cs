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
    public class ZajeciaController : Controller
    {
        private readonly SwpContext _context;

        public ZajeciaController(SwpContext context)
        {
            _context = context;
        }

        // GET: Zajecia
        public async Task<IActionResult> Index()
        {
            var swpContext = _context.Zajecie.Include(z => z.IdgrupyNavigation);
            return View(await swpContext.ToListAsync());
        }

        // GET: Zajecia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zajecie = await _context.Zajecie
                .Include(z => z.IdgrupyNavigation)
                .FirstOrDefaultAsync(m => m.Idzajecia == id);
            if (zajecie == null)
            {
                return NotFound();
            }

            return View(zajecie);
        }

        // GET: Zajecia/Create
        public IActionResult Create()
        {
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy");
            return View();
        }

        // POST: Zajecia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idgrupy,Datazajecia")] Zajecie zajecie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zajecie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zajecie.Idgrupy);
            return View(zajecie);
        }

        // GET: Zajecia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zajecie = await _context.Zajecie.FindAsync(id);
            if (zajecie == null)
            {
                return NotFound();
            }
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zajecie.Idgrupy);
            return View(zajecie);
        }

        // POST: Zajecia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idzajecia,Idgrupy,Datazajecia")] Zajecie zajecie)
        {
            if (id != zajecie.Idzajecia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zajecie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZajecieExists(zajecie.Idzajecia))
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
            ViewData["Idgrupy"] = new SelectList(_context.Grupa, "Idgrupy", "Idgrupy", zajecie.Idgrupy);
            return View(zajecie);
        }

        // GET: Zajecia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zajecie = await _context.Zajecie
                .Include(z => z.IdgrupyNavigation)
                .FirstOrDefaultAsync(m => m.Idzajecia == id);
            if (zajecie == null)
            {
                return NotFound();
            }

            return View(zajecie);
        }

        // POST: Zajecia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zajecie = await _context.Zajecie.FindAsync(id);
            _context.Zajecie.Remove(zajecie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZajecieExists(int id)
        {
            return _context.Zajecie.Any(e => e.Idzajecia == id);
        }
    }
}
