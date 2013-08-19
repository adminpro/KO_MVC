using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vShipmentMap : EntityTypeConfiguration<vShipment>
    {
        public vShipmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ShipmentId, t.SiteId, t.HawbNumber, t.CustomerReference, t.Weight, t.DefaultWeight, t.ChargableWeight, t.CustomsValue, t.PackageLength, t.PackageWidth, t.PackageDepth, t.PackageVolume, t.DefaultPackageLength, t.DefaultPackageWidth, t.DefaultPackageDepth, t.DefaultPackageVolume, t.ShipperName, t.ShipperAddress1, t.ShipperCountry, t.ConsigneeName, t.ConsigneeAddress1, t.ConsigneeCountry });

            // Properties
            this.Property(t => t.ShipmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HawbNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerReference)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CarrierReference)
                .HasMaxLength(50);

            this.Property(t => t.WeightUnit)
                .HasMaxLength(3);

            this.Property(t => t.DefaultWeightUnit)
                .HasMaxLength(200);

            this.Property(t => t.ChargableWeightUnit)
                .HasMaxLength(3);

            this.Property(t => t.GoodsDescription)
                .HasMaxLength(50);

            this.Property(t => t.ValueCurrency)
                .HasMaxLength(3);

            this.Property(t => t.GoodsOriginCountry)
                .HasMaxLength(2);

            this.Property(t => t.Remarks)
                .HasMaxLength(50);

            this.Property(t => t.CarrierOriginCode)
                .HasMaxLength(50);

            this.Property(t => t.CarrierDestinationCode)
                .HasMaxLength(50);

            this.Property(t => t.ServiceLevel)
                .HasMaxLength(50);

            this.Property(t => t.PackageDimensionsUnit)
                .HasMaxLength(3);

            this.Property(t => t.DefaultPackageDimensionsUnit)
                .HasMaxLength(200);

            this.Property(t => t.ShipperName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipperAddress1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShipperAddress2)
                .HasMaxLength(50);

            this.Property(t => t.ShipperCity)
                .HasMaxLength(50);

            this.Property(t => t.ShipperPostalCode)
                .HasMaxLength(50);

            this.Property(t => t.ShipperCountry)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ShipperTelephone)
                .HasMaxLength(50);

            this.Property(t => t.ShipperEmail)
                .HasMaxLength(80);

            this.Property(t => t.ConsigneeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeAddress1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeAddress2)
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeCity)
                .HasMaxLength(50);

            this.Property(t => t.ConsigneePostalCode)
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeCountry)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ConsigneeTelephone)
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeEmail)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("vShipments");
            this.Property(t => t.ShipmentId).HasColumnName("ShipmentId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.HawbNumber).HasColumnName("HawbNumber");
            this.Property(t => t.CustomerReference).HasColumnName("CustomerReference");
            this.Property(t => t.CarrierReference).HasColumnName("CarrierReference");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.Piece).HasColumnName("Piece");
            this.Property(t => t.Pieces).HasColumnName("Pieces");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit");
            this.Property(t => t.DefaultWeight).HasColumnName("DefaultWeight");
            this.Property(t => t.DefaultWeightUnit).HasColumnName("DefaultWeightUnit");
            this.Property(t => t.ChargableWeight).HasColumnName("ChargableWeight");
            this.Property(t => t.ChargableWeightUnit).HasColumnName("ChargableWeightUnit");
            this.Property(t => t.GoodsDescription).HasColumnName("GoodsDescription");
            this.Property(t => t.CustomsValue).HasColumnName("CustomsValue");
            this.Property(t => t.CODValue).HasColumnName("CODValue");
            this.Property(t => t.ValueCurrency).HasColumnName("ValueCurrency");
            this.Property(t => t.GoodsOriginCountry).HasColumnName("GoodsOriginCountry");
            this.Property(t => t.PickupDate).HasColumnName("PickupDate");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.CarrierOriginCode).HasColumnName("CarrierOriginCode");
            this.Property(t => t.CarrierDestinationCode).HasColumnName("CarrierDestinationCode");
            this.Property(t => t.ServiceLevel).HasColumnName("ServiceLevel");
            this.Property(t => t.PackageLength).HasColumnName("PackageLength");
            this.Property(t => t.PackageWidth).HasColumnName("PackageWidth");
            this.Property(t => t.PackageDepth).HasColumnName("PackageDepth");
            this.Property(t => t.PackageVolume).HasColumnName("PackageVolume");
            this.Property(t => t.PackageDimensionsUnit).HasColumnName("PackageDimensionsUnit");
            this.Property(t => t.DefaultConversionRate).HasColumnName("DefaultConversionRate");
            this.Property(t => t.DefaultPackageLength).HasColumnName("DefaultPackageLength");
            this.Property(t => t.DefaultPackageWidth).HasColumnName("DefaultPackageWidth");
            this.Property(t => t.DefaultPackageDepth).HasColumnName("DefaultPackageDepth");
            this.Property(t => t.DefaultPackageVolume).HasColumnName("DefaultPackageVolume");
            this.Property(t => t.DefaultPackageDimensionsUnit).HasColumnName("DefaultPackageDimensionsUnit");
            this.Property(t => t.ShipperPartyId).HasColumnName("ShipperPartyId");
            this.Property(t => t.ConsigneePartyId).HasColumnName("ConsigneePartyId");
            this.Property(t => t.ShipperName).HasColumnName("ShipperName");
            this.Property(t => t.ShipperAddress1).HasColumnName("ShipperAddress1");
            this.Property(t => t.ShipperAddress2).HasColumnName("ShipperAddress2");
            this.Property(t => t.ShipperCity).HasColumnName("ShipperCity");
            this.Property(t => t.ShipperPostalCode).HasColumnName("ShipperPostalCode");
            this.Property(t => t.ShipperCountry).HasColumnName("ShipperCountry");
            this.Property(t => t.ShipperTelephone).HasColumnName("ShipperTelephone");
            this.Property(t => t.ShipperEmail).HasColumnName("ShipperEmail");
            this.Property(t => t.ConsigneeName).HasColumnName("ConsigneeName");
            this.Property(t => t.ConsigneeAddress1).HasColumnName("ConsigneeAddress1");
            this.Property(t => t.ConsigneeAddress2).HasColumnName("ConsigneeAddress2");
            this.Property(t => t.ConsigneeCity).HasColumnName("ConsigneeCity");
            this.Property(t => t.ConsigneePostalCode).HasColumnName("ConsigneePostalCode");
            this.Property(t => t.ConsigneeCountry).HasColumnName("ConsigneeCountry");
            this.Property(t => t.ConsigneeTelephone).HasColumnName("ConsigneeTelephone");
            this.Property(t => t.ConsigneeEmail).HasColumnName("ConsigneeEmail");
        }
    }
}
