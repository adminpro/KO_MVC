using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ServiceLevel
    {
        public ServiceLevel()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int ServiceLevelId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
