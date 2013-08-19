using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class LabelVersion
    {
        public LabelVersion()
        {
            this.LabelTemplates = new List<LabelTemplate>();
        }

        public int LabelVersionId { get; set; }
        public int LabelId { get; set; }
        public float Version { get; set; }
        public string LabelText { get; set; }
        public virtual ICollection<LabelTemplate> LabelTemplates { get; set; }
    }
}
