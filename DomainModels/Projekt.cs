namespace TrainChecklist.DomainModels
{
    public class Projekt
    {
        
        public int Id { get; set; }
        public int NazwaProjektu { get; set; }
        public string NazwaKlienta { get; set; }
        //  public Icollection 

        public Projekt(){}

        public Projekt(int id, int nazwaProjektu, string nazwaKlienta)
        {
            this.Id = id;
            this.NazwaProjektu = nazwaProjektu;
            this.NazwaKlienta = nazwaKlienta;

        }
    }
    
}