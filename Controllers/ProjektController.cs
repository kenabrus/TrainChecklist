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
    public class ProjektController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjektController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Projekt
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projekts.ToListAsync());
        }

        // GET: Projekt/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekt = await _context.Projekts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projekt == null)
            {
                return NotFound();
            }

            return View(projekt);
        }

        // GET: Projekt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projekt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NazwaProjektu,DataRozpoczeciaProjektu,DataZakonczeniaProjektu")] Projekt projekt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projekt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projekt);
        }

        // GET: Projekt/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekt = await _context.Projekts.FindAsync(id);
            if (projekt == null)
            {
                return NotFound();
            }
            return View(projekt);
        }

        // POST: Projekt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NazwaProjektu,DataRozpoczeciaProjektu,DataZakonczeniaProjektu")] Projekt projekt)
        {
            if (id != projekt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var p = await _context.Projekts.FirstOrDefaultAsync(m => m.Id == id);
                    p.NazwaProjektu = projekt.NazwaProjektu;
                    p.DataRozpoczeciaProjektu = projekt.DataRozpoczeciaProjektu;
                    p.DataZakonczeniaProjektu = projekt.DataZakonczeniaProjektu;
                    _context.Update(p);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjektExists(projekt.Id))
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
            return View(projekt);
        }

        // GET: Projekt/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekt = await _context.Projekts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projekt == null)
            {
                return NotFound();
            }

            return View(projekt);
        }

        // POST: Projekt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var projekt = await _context.Projekts.FindAsync(id);
            _context.Projekts.Remove(projekt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjektExists(long id)
        {
            return _context.Projekts.Any(e => e.Id == id);
        }
    }
}
