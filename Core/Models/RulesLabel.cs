using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class RulesLabel
    {
        public int RulesLabelsId { get; set; }
        public int RoutingRuleId { get; set; }
        public int LabelTemplateId { get; set; }
        public virtual LabelTemplate LabelTemplate { get; set; }
        public virtual RoutingRule RoutingRule { get; set; }
    }
}
