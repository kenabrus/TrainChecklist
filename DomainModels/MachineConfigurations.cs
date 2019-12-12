using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class MachineConfigurations
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public string Name { get; set; }
        public string Configuration { get; set; }
        public int Version { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Machines Machine { get; set; }
    }
}
