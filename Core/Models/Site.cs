using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Site
    {
        public Site()
        {
            this.ParcelPrices = new List<ParcelPrice>();
            this.ParcelSizes = new List<ParcelSize>();
            this.ParcelWeights = new List<ParcelWeight>();
            this.RoutingRules = new List<RoutingRule>();
            this.Shipments = new List<Shipment>();
            this.TimeRanges = new List<TimeRanx>();
        }

        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ParcelPrice> ParcelPrices { get; set; }
        public virtual ICollection<ParcelSize> ParcelSizes { get; set; }
        public virtual ICollection<ParcelWeight> ParcelWeights { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<TimeRanx> TimeRanges { get; set; }
    }
}
