using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TrackingMap
    {
        public int TrackingMapId { get; set; }
        public Nullable<int> CarrierId { get; set; }
        public string EswCode { get; set; }
        public string CarrierCode { get; set; }
        public string Description { get; set; }
    }
}
