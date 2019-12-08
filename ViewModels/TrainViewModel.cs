using System;
using System.ComponentModel.DataAnnotations;

namespace TrainChecklist.ViewModels
{
    public class TrainViewModel
    {
        public int Id {get; set;}
        [Display(Name ="Name")]
        [StringLength(50, MinimumLength = 1)]        
        public string Name {get; set;}
        [Display(Name ="Begin Time")]
        [DataType(DataType.Date)]
        public DateTime BeginTime {get; set;}
        [Display(Name ="End Time")]
        [DataType(DataType.Date)]
        public DateTime EndTime {get; set;} 
    }
}