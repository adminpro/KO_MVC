using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class RoutingRule
    {
        public RoutingRule()
        {
            this.RulesLabels = new List<RulesLabel>();
        }

        public int RoutingRuleId { get; set; }
        public int SiteId { get; set; }
        public string DestinationCountryIso { get; set; }
        public Nullable<int> ServiceLevelId { get; set; }
        public int PriorityLevel { get; set; }
        public int CarrierId { get; set; }
        public Nullable<int> ParcelWeightId { get; set; }
        public Nullable<int> ParcelSizeRangeId { get; set; }
        public Nullable<int> ParcelPriceId { get; set; }
        public Nullable<int> TimeRangeId { get; set; }
        public Nullable<int> DayId { get; set; }
        public virtual Carrier Carrier { get; set; }
        public virtual Day Day { get; set; }
        public virtual ParcelPrice ParcelPrice { get; set; }
        public virtual ParcelSizeRange ParcelSizeRange { get; set; }
        public virtual ParcelWeight ParcelWeight { get; set; }
        public virtual ServiceLevel ServiceLevel { get; set; }
        public virtual Site Site { get; set; }
        public virtual TimeRanx TimeRanx { get; set; }
        public virtual ICollection<RulesLabel> RulesLabels { get; set; }
    }
}
