using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vParcelWeight
    {
        public int ParcelWeightId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public float FromWeight { get; set; }
        public float ToWeight { get; set; }
        public string WeightUnit { get; set; }
        public double ConversionRateToDefaultUnit { get; set; }
        public double DefaultFromWeight { get; set; }
        public double DefaultToWeight { get; set; }
        public string DefaultWeightUnit { get; set; }
    }
}
