using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ShipmentItem
    {
        public long ShipmentId { get; set; }
        public long ItemId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public string CountryOfOrigin { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
