using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class LabelTemplate
    {
        public LabelTemplate()
        {
            this.RulesLabels = new List<RulesLabel>();
        }

        public int LabelTemplateId { get; set; }
        public Nullable<int> CarrierId { get; set; }
        public string LabelName { get; set; }
        public int LabelVersionId { get; set; }
        public virtual Carrier Carrier { get; set; }
        public virtual LabelVersion LabelVersion { get; set; }
        public virtual ICollection<RulesLabel> RulesLabels { get; set; }
    }
}
