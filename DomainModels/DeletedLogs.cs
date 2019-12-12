using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class DeletedLogs
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
