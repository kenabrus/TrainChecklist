using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainChecklist.Models
{
    public class Projekt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id {get; private set;}

        [Required]
        [StringLength(50)]
        [Display(Name = "Nazwa projektu")]
        public string NazwaProjektu {get; set;}

        [Display(Name = "Data rozpoczęcia projektu")]
        [DataType(DataType.Date)]
        public DateTime DataRozpoczeciaProjektu { get; set; }

        [Display(Name = "Data zakończenia projektu")]
        [DataType(DataType.Date)]
        public DateTime DataZakonczeniaProjektu { get; set; }

        // w jednym projekcie może być wiele pojazdów
        public ICollection<Pojazd> Pojazdy {get; set;}

        public Projekt(){}
    }
}