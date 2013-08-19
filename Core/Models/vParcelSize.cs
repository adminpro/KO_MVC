using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vParcelSize
    {
        public int ParcelSizeId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public string ParcelSizeName { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Volume { get; set; }
        public string Unit { get; set; }
        public double ConversionRateToDefaultUnit { get; set; }
        public double DefaultLength { get; set; }
        public double DefaultWidth { get; set; }
        public double DefaultDepth { get; set; }
        public double DefaultVolume { get; set; }
        public string DefaultUnit { get; set; }
    }
}
