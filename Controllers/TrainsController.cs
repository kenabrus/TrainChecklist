using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainChecklist.Models;

namespace TrainChecklist.Controllers
{
    public class TrainsController : Controller
    {

        public TrainsController()
        {           
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}