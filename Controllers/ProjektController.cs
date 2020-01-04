using Microsoft.AspNetCore.Mvc;
using TrainChecklist.DomainModels;
using System.Collections.Generic;

namespace TrainChecklist.Controllers
{
    public class ProjektController : Controller
    {
        public ActionResult Random()
        {
            var projekt = new Projekt() {NazwaProjektu = 4413};
            return View();    
        } 
            
    }
}