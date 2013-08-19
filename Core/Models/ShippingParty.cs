using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ShippingParty
    {
        public ShippingParty()
        {
            this.Shipments = new List<Shipment>();
            this.Shipments1 = new List<Shipment>();
        }

        public long ShippingPartyId { get; set; }
        public Nullable<int> ShippingPartyTypeId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<Shipment> Shipments1 { get; set; }
        public virtual ShippingPartyType ShippingPartyType { get; set; }
    }
}
