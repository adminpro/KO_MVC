using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class MeasureUnit
    {
        public MeasureUnit()
        {
            this.ConversionRates = new List<ConversionRate>();
            this.ConversionRates1 = new List<ConversionRate>();
        }

        public int MeasureUnitId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<ConversionRate> ConversionRates { get; set; }
        public virtual ICollection<ConversionRate> ConversionRates1 { get; set; }
    }
}
