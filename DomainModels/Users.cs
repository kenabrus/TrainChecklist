using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class Users
    {
        public Users()
        {
            Logs = new HashSet<Logs>();
            Machines = new HashSet<Machines>();
            OneTimeOperations = new HashSet<OneTimeOperations>();
            RefreshTokens = new HashSet<RefreshTokens>();
            UserSubscriptions = new HashSet<UserSubscriptions>();
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string KeyHash { get; set; }
        public bool Locked { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? SubscriptionId { get; set; }

        public virtual UserSubscriptions Subscription { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Machines> Machines { get; set; }
        public virtual ICollection<OneTimeOperations> OneTimeOperations { get; set; }
        public virtual ICollection<RefreshTokens> RefreshTokens { get; set; }
        public virtual ICollection<UserSubscriptions> UserSubscriptions { get; set; }
    }
}
