using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class SystemUsers
    {
        public SystemUsers()
        {
            Logs = new HashSet<Logs>();
        }

        public long Id { get; set; }
        public long MachineId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Machines Machine { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
    }
}
