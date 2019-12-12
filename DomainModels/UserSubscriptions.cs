using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class UserSubscriptions
    {
        public UserSubscriptions()
        {
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public long SubscriptionId { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int Months { get; set; }
        public int MachinesLimit { get; set; }
        public int RetentionDays { get; set; }
        public string Machines { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public virtual Subscriptions Subscription { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
