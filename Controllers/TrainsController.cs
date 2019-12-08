using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainChecklist.Models;
using TrainChecklist.Data;
using Microsoft.EntityFrameworkCore;
using TrainChecklist.DomainModels;
using TrainChecklist.Repositories;

namespace TrainChecklist.Controllers
{
    public class TrainsController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly ITrainRepository _repository;

        public TrainsController(ITrainRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
        }

        // public async Task<IActionResult> Details(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var train = await _context.Trains
        //         .SingleOrDefaultAsync(m => m.Id == id);

        //     if (train == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(train);
        // }

        // public IActionResult Create()
        // {
        //     return View();
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Id, Name, BeginTime, EndTime")] Train train)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Trains.Add(train);
        //         await _context.SaveChangesAsync();
        //     }
        //     return View(train);
        // }

        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }
        //     var train = await _context.Trains.SingleOrDefaultAsync(m => m.Id == id);
        //     if (train == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(train);
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("Id, Name, BeginTime, EndTime")] Train train)
        // {
        //     if (id != train.Id)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Trains.Update(train);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!TrainExists(train.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(train);
        // }

        // public async Task<IActionResult> Delete(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var train = await _context.Trains
        //         .SingleOrDefaultAsync(m => m.Id == id);

        //     if (train == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(train);
        // }

        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(int id)
        // {
        //     var train = await _context.Trains.SingleOrDefaultAsync(m => m.Id == id);
        //     _context.Trains.Remove(train);
        //     await _context.SaveChangesAsync();

        //     return RedirectToAction(nameof(Index));
        // }

        // private bool TrainExists(int id)
        // {
        //     return _context.Trains.Any(e => e.Id == id);
        // }
    }
}