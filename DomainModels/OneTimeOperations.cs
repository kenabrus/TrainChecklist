using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class OneTimeOperations
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Type { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ConsumedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public virtual Users User { get; set; }
    }
}
