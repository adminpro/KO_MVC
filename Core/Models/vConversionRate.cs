using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vConversionRate
    {
        public string FromUnitCode { get; set; }
        public string FromUnitName { get; set; }
        public string ToUnitCode { get; set; }
        public string ToUnitName { get; set; }
        public double ConversionRate { get; set; }
    }
}