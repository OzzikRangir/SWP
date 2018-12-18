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
    public class GrupaController : Controller
    {
        private readonly SwpContext _context;

        public GrupaController(SwpContext context)
        {
            _context = context;
        }

        // GET: Grupa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grupa.ToListAsync());
        }

        // GET: Grupa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa
                .FirstOrDefaultAsync(m => m.Idgrupy == id);
            if (grupa == null)
            {
                return NotFound();
            }

            return View(grupa);
        }

        // GET: Grupa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Grupa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idgrupy,Nazwagrupy")] Grupa grupa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grupa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grupa);
        }

        // GET: Grupa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa.FindAsync(id);
            if (grupa == null)
            {
                return NotFound();
            }
            return View(grupa);
        }

        // POST: Grupa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Idgrupy,Nazwagrupy")] Grupa grupa)
        {
            if (id != grupa.Idgrupy)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupaExists(grupa.Idgrupy))
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
            return View(grupa);
        }

        // GET: Grupa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa
                .FirstOrDefaultAsync(m => m.Idgrupy == id);
            if (grupa == null)
            {
                return NotFound();
            }

            return View(grupa);
        }

        // POST: Grupa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var grupa = await _context.Grupa.FindAsync(id);
            _context.Grupa.Remove(grupa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupaExists(string id)
        {
            return _context.Grupa.Any(e => e.Idgrupy == id);
        }
    }
}
