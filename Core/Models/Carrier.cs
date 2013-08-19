using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Carrier
    {
        public Carrier()
        {
            this.LabelTemplates = new List<LabelTemplate>();
            this.RoutingRules = new List<RoutingRule>();
        }

        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierCode { get; set; }
        public virtual ICollection<LabelTemplate> LabelTemplates { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
