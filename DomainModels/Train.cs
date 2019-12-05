using System;
using System.ComponentModel.DataAnnotations;

namespace TrainChecklist.DomainModels
{
    public class Train
    {
        [Key]
        public int Id {get; set;}
        [Display(Name ="Name")]
        [StringLength(50, MinimumLength = 1)]        
        public string Name {get; set;}
        [DataType(DataType.Date)]
        public DateTime BeginTime {get; set;}
        [DataType(DataType.Date)]
        public DateTime EndTime {get; set;}

    }
}