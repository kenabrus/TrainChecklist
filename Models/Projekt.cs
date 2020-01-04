using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainChecklist.Models
{
    public class Projekt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id {get; private set;}
        public string NazwaProjektu {get; set;}
        public DateTime DataRozpoczeciaProjektu { get; set; }
        public DateTime DataZakonczeniaProjektu { get; set; }

        public Projekt(){}
    }
}