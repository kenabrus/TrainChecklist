using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainChecklist.Data;
using TrainChecklist.Models;

namespace TrainChecklist.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCalendarEvents(string start, string end)
        {
            List<Event> events = _context.Events.ToList();

            return Json(events);
        }

        [HttpPost]
        public IActionResult UpdateEvent([FromBody] Event evt)
        {
            string message = String.Empty;
            _context.Update(evt);
            _context.SaveChanges();
            //message = _context.Events.Update(evt);

            return Json(new { message });
        }

        [HttpPost]
        public IActionResult AddEvent([FromBody] Event evt)
        {
            string message = String.Empty;
            int eventId = 0;

            _context.Add(evt);
            _context.SaveChanges();

            return Json(new { message, eventId });
        }

        [HttpPost]
        public IActionResult DeleteEvent([FromBody] Event evt)
        {
            string message = String.Empty;
            // var ev = _context.Events.SingleOrDefault(i => i.EventId == evt.EventId);
            // _context.Events.Remove(ev);
            // _context.SaveChanges();

            return Json(new { message });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
