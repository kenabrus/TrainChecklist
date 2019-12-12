using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class RefreshTokens
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RevokedAt { get; set; }

        public virtual Users User { get; set; }
    }
}
