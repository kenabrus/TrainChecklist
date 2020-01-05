using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainChecklist.Models
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        [Display(Name = "Pacjent")]
        public string Title { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Display(Name = "Od")]
        public string StartAt { get; set; }
        [Display(Name = "Do")]
        public string EndAt { get; set; }
        public bool IsFullDay { get; set; }
    }
}
