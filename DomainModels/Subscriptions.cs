using System;
using System.Collections.Generic;

namespace TrainChecklist.DomainModels
{
    public partial class Subscriptions
    {
        public Subscriptions()
        {
            UserSubscriptions = new HashSet<UserSubscriptions>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int MachinesLimit { get; set; }
        public int RetentionDays { get; set; }

        public virtual ICollection<UserSubscriptions> UserSubscriptions { get; set; }
    }
}
