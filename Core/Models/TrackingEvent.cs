using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TrackingEvent
    {
        public long TrackingEventId { get; set; }
        public string eShopWorldReferenceNo { get; set; }
        public string CarrierReferenceNo { get; set; }
        public Nullable<int> CarrierId { get; set; }
        public string EventCode { get; set; }
        public string EventCodeDesc { get; set; }
        public Nullable<System.DateTime> EventDateTime { get; set; }
        public string EventLocation { get; set; }
        public string Signatory { get; set; }
        public string AccountNumber { get; set; }
    }
}
