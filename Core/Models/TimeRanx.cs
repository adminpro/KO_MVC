using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TimeRanx
    {
        public TimeRanx()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int TimeRangeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> SiteId { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
        public virtual Site Site { get; set; }
    }
}
