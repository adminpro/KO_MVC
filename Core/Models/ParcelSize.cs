using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ParcelSize
    {
        public ParcelSize()
        {
            this.ParcelSizeRanges = new List<ParcelSizeRange>();
            this.ParcelSizeRanges1 = new List<ParcelSizeRange>();
        }

        public int ParcelSizeId { get; set; }
        public Nullable<int> SiteId { get; set; }
        public string ParcelSizeName { get; set; }
        public Nullable<float> Length { get; set; }
        public Nullable<float> Width { get; set; }
        public Nullable<float> Depth { get; set; }
        public Nullable<float> Volume { get; set; }
        public string Unit { get; set; }
        public virtual ICollection<ParcelSizeRange> ParcelSizeRanges { get; set; }
        public virtual ICollection<ParcelSizeRange> ParcelSizeRanges1 { get; set; }
        public virtual Site Site { get; set; }
    }
}
