using System;

namespace TrainChecklist.DomainModels
{
    public class Train
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime BeginTime {get; set;}
        public DateTime EndTime {get; set;}

    }
}