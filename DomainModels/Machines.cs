using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class Machines
    {
        public Machines()
        {
            Logs = new HashSet<Logs>();
            MachineConfigurations = new HashSet<MachineConfigurations>();
            SystemUsers = new HashSet<SystemUsers>();
        }

        public long Id { get; set; }
        public long UserId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<MachineConfigurations> MachineConfigurations { get; set; }
        public virtual ICollection<SystemUsers> SystemUsers { get; set; }
    }
}
