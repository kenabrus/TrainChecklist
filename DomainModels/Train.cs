using System;
using System.ComponentModel.DataAnnotations;

namespace TrainChecklist.DomainModels
{
    public class Train
    {
        public long Id {get; set;}        
        public string Name {get; set;}
        public DateTime BeginTime {get; set;}
        public DateTime EndTime {get; set;}

    }
}