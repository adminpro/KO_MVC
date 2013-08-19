using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ParcelWeight
    {
        public ParcelWeight()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int ParcelWeightId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<float> FromWeight { get; set; }
        public Nullable<float> ToWeight { get; set; }
        public string WeightUnit { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
