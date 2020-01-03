namespace TrainChecklist.DomainModels
{
    public class Pojazd
    {
        public int Id {get; set;}
        public int NumerPojazdu {get; private set;}
        public string TypPojazdu {get; set;}
        public int IloscWagonow {get; set;}

        public Pojazd(){}

        public void SetNumerPojazdu(int nazwa)
        {
            NumerPojazdu = nazwa;
        }
    }
}