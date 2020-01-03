using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public class Projekt
    {
        public int Id { get; set; }
        public int NazwaProjektu { get; set; }
        public string NazwaKlienta { get; set; }
        public ICollection<Pojazd> Pojazdy { get; set; }
        public string Zatwierdzajacy { get; set; }
        public DateTime DataZatwierdzenia { get; set; }
        public ICollection<Protokol> Protokoly {get; set;}

        public Projekt() { }

        public Projekt(int id, int nazwaProjektu, string nazwaKlienta)
        {
            this.Id = id;
            this.NazwaProjektu = nazwaProjektu;
            this.NazwaKlienta = nazwaKlienta;

        }
    }

}