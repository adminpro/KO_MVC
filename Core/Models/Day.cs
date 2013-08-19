using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Day
    {
        public Day()
        {
            this.RoutingRules = new List<RoutingRule>();
        }

        public int DayId { get; set; }
        public string Name { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public virtual ICollection<RoutingRule> RoutingRules { get; set; }
    }
}
