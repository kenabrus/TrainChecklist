using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainChecklist.Data;
using TrainChecklist.Models;

namespace TrainChecklist.Controllers
{
    public class PojazdController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PojazdController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pojazd
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pojazdy.Include(p => p.Projekt);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pojazd/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pojazd = await _context.Pojazdy
                .Include(p => p.Projekt)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pojazd == null)
            {
                return NotFound();
            }

            return View(pojazd);
        }

        // GET: Pojazd/Create
        public IActionResult Create()
        {
            ViewData["ProjektId"] = new SelectList(_context.Projekty, "Id", "NazwaProjektu");
            return View();
        }

        // POST: Pojazd/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NazwaPojazdu,ProjektId")] Pojazd pojazd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pojazd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjektId"] = new SelectList(_context.Projekty, "Id", "NazwaProjektu", pojazd.ProjektId);
            return View(pojazd);
        }

        // GET: Pojazd/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pojazd = await _context.Pojazdy.FindAsync(id);
            if (pojazd == null)
            {
                return NotFound();
            }
            ViewData["ProjektId"] = new SelectList(_context.Projekty, "Id", "NazwaProjektu", pojazd.ProjektId);
            return View(pojazd);
        }

        // POST: Pojazd/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NazwaPojazdu,ProjektId")] Pojazd pojazd)
        {
            if (id != pojazd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pojazd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PojazdExists(pojazd.Id))
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
            ViewData["ProjektId"] = new SelectList(_context.Projekty, "Id", "NazwaProjektu", pojazd.ProjektId);
            return View(pojazd);
        }

        // GET: Pojazd/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pojazd = await _context.Pojazdy
                .Include(p => p.Projekt)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pojazd == null)
            {
                return NotFound();
            }

            return View(pojazd);
        }

        // POST: Pojazd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pojazd = await _context.Pojazdy.FindAsync(id);
            _context.Pojazdy.Remove(pojazd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PojazdExists(long id)
        {
            return _context.Pojazdy.Any(e => e.Id == id);
        }
    }
}
