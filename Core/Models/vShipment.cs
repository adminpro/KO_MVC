using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class vShipment
    {
        public long ShipmentId { get; set; }
        public int SiteId { get; set; }
        public string HawbNumber { get; set; }
        public string CustomerReference { get; set; }
        public string CarrierReference { get; set; }
        public Nullable<int> CarrierId { get; set; }
        public Nullable<int> Piece { get; set; }
        public Nullable<int> Pieces { get; set; }
        public float Weight { get; set; }
        public string WeightUnit { get; set; }
        public double DefaultWeight { get; set; }
        public string DefaultWeightUnit { get; set; }
        public float ChargableWeight { get; set; }
        public string ChargableWeightUnit { get; set; }
        public string GoodsDescription { get; set; }
        public float CustomsValue { get; set; }
        public Nullable<float> CODValue { get; set; }
        public string ValueCurrency { get; set; }
        public string GoodsOriginCountry { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public string Remarks { get; set; }
        public string CarrierOriginCode { get; set; }
        public string CarrierDestinationCode { get; set; }
        public string ServiceLevel { get; set; }
        public float PackageLength { get; set; }
        public float PackageWidth { get; set; }
        public float PackageDepth { get; set; }
        public float PackageVolume { get; set; }
        public string PackageDimensionsUnit { get; set; }
        public Nullable<double> DefaultConversionRate { get; set; }
        public double DefaultPackageLength { get; set; }
        public double DefaultPackageWidth { get; set; }
        public double DefaultPackageDepth { get; set; }
        public double DefaultPackageVolume { get; set; }
        public string DefaultPackageDimensionsUnit { get; set; }
        public Nullable<long> ShipperPartyId { get; set; }
        public Nullable<long> ConsigneePartyId { get; set; }
        public string ShipperName { get; set; }
        public string ShipperAddress1 { get; set; }
        public string ShipperAddress2 { get; set; }
        public string ShipperCity { get; set; }
        public string ShipperPostalCode { get; set; }
        public string ShipperCountry { get; set; }
        public string ShipperTelephone { get; set; }
        public string ShipperEmail { get; set; }
        public string ConsigneeName { get; set; }
        public string ConsigneeAddress1 { get; set; }
        public string ConsigneeAddress2 { get; set; }
        public string ConsigneeCity { get; set; }
        public string ConsigneePostalCode { get; set; }
        public string ConsigneeCountry { get; set; }
        public string ConsigneeTelephone { get; set; }
        public string ConsigneeEmail { get; set; }
    }
}
