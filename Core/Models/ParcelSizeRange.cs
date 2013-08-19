using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ParcelSizeRange
    {
        public ParcelSizeRange()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int ParcelSizeRangeId { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> FromParcelSizeId { get; set; }
        public Nullable<int> ToParcelSizeId { get; set; }
        public virtual ParcelSize ParcelSize { get; set; }
        public virtual ParcelSize ParcelSize1 { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
