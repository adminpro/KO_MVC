using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ShippingPartyType
    {
        public ShippingPartyType()
        {
            this.ShippingParties = new List<ShippingParty>();
        }

        public int ShippingPartyTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ShippingParty> ShippingParties { get; set; }
    }
}
