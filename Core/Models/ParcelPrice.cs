using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ParcelPrice
    {
        public ParcelPrice()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int ParcelPriceId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<float> FromPrice { get; set; }
        public Nullable<float> ToPrice { get; set; }
        public string Currency { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
