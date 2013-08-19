using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            this.ShipmentCarrierDatas = new List<ShipmentCarrierData>();
            this.ShipmentItems = new List<ShipmentItem>();
        }

        public long ShipmentId { get; set; }
        public int SiteId { get; set; }
        public string EshopReference { get; set; }
        public string CustomerReference { get; set; }
        public string CarrierReference { get; set; }
        public Nullable<int> CarrierId { get; set; }
        public Nullable<int> Piece { get; set; }
        public Nullable<int> Pieces { get; set; }
        public Nullable<float> Weight { get; set; }
        public string WeightUnit { get; set; }
        public Nullable<float> ChargableWeight { get; set; }
        public string ChargableWeightUnit { get; set; }
        public string GoodsDescription { get; set; }
        public Nullable<float> CustomsValue { get; set; }
        public Nullable<float> CODValue { get; set; }
        public string ValueCurrency { get; set; }
        public string GoodsOriginCountry { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public string Remarks { get; set; }
        public string CarrierOriginCode { get; set; }
        public string CarrierDestinationCode { get; set; }
        public string ServiceLevel { get; set; }
        public Nullable<float> PackageLength { get; set; }
        public Nullable<float> PackageWidth { get; set; }
        public Nullable<float> PackageDepth { get; set; }
        public string PackageDimensionsUnit { get; set; }
        public Nullable<long> ShipperPartyId { get; set; }
        public Nullable<long> ConsigneePartyId { get; set; }
        public Nullable<float> PackageVolume { get; set; }
        public string PreviousServiceLevel { get; set; }
        public Nullable<float> PreviousWeight { get; set; }
        public string PreviousWeightUnit { get; set; }
        public Nullable<System.DateTime> BrokerProcessingDate { get; set; }
        public Nullable<float> BrokerBillingCharge { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> CreationFileId { get; set; }
        public Nullable<int> BrokerManifestFileId { get; set; }
        public Nullable<int> CarrierManifestFileId { get; set; }
        public virtual ICollection<ShipmentCarrierData> ShipmentCarrierDatas { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual Site Site { get; set; }
        public virtual ShippingParty ShippingParty { get; set; }
        public virtual ShippingParty ShippingParty1 { get; set; }
    }
}
