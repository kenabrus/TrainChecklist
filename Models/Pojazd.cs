using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainChecklist.Models
{
    public class Pojazd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id {get; private set;}

        [Required]
        [StringLength(100)]
        [Display(Name = "Nazwa pojazdu")]

        public string NazwaPojazdu {get; set;}

        // odwołanie do projektu w którym występuje pojazd
        public long ProjektId {get; set;}
        public Projekt Projekt {get; set;}
    }
}