using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ShipmentCarrierData
    {
        public long ShipmentCarrierDataId { get; set; }
        public long ShipmentId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
