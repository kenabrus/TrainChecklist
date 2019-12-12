using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class Logs
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long MachineId { get; set; }
        public long SystemUserId { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public string File { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Date { get; set; }

        public virtual Machines Machine { get; set; }
        public virtual SystemUsers SystemUser { get; set; }
        public virtual Users User { get; set; }
    }
}
