using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ConversionRate
    {
        public int ConversionRateId { get; set; }
        public int FromMeasureUnitId { get; set; }
        public int ToMeasureUnitId { get; set; }
        public double ConversionRate1 { get; set; }
        public virtual MeasureUnit MeasureUnit { get; set; }
        public virtual MeasureUnit MeasureUnit1 { get; set; }
    }
}
