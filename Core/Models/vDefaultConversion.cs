using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vDefaultConversion
    {
        public string FromUnitCode { get; set; }
        public string ToUnitCode { get; set; }
        public double ConversionRate { get; set; }
    }
}
