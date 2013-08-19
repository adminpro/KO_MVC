using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ShipmentMap : EntityTypeConfiguration<Shipment>
    {
        public ShipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ShipmentId);

            // Properties
            this.Property(t => t.EshopReference)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerReference)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CarrierReference)
                .HasMaxLength(50);

            this.Property(t => t.WeightUnit)
                .HasMaxLength(3);

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

            this.Property(t => t.PreviousServiceLevel)
                .HasMaxLength(50);

            this.Property(t => t.PreviousWeightUnit)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("Shipments");
            this.Property(t => t.ShipmentId).HasColumnName("ShipmentId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.EshopReference).HasColumnName("EshopReference");
            this.Property(t => t.CustomerReference).HasColumnName("CustomerReference");
            this.Property(t => t.CarrierReference).HasColumnName("CarrierReference");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.Piece).HasColumnName("Piece");
            this.Property(t => t.Pieces).HasColumnName("Pieces");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit");
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
            this.Property(t => t.PackageDimensionsUnit).HasColumnName("PackageDimensionsUnit");
            this.Property(t => t.ShipperPartyId).HasColumnName("ShipperPartyId");
            this.Property(t => t.ConsigneePartyId).HasColumnName("ConsigneePartyId");
            this.Property(t => t.PackageVolume).HasColumnName("PackageVolume");
            this.Property(t => t.PreviousServiceLevel).HasColumnName("PreviousServiceLevel");
            this.Property(t => t.PreviousWeight).HasColumnName("PreviousWeight");
            this.Property(t => t.PreviousWeightUnit).HasColumnName("PreviousWeightUnit");
            this.Property(t => t.BrokerProcessingDate).HasColumnName("BrokerProcessingDate");
            this.Property(t => t.BrokerBillingCharge).HasColumnName("BrokerBillingCharge");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.CreationFileId).HasColumnName("CreationFileId");
            this.Property(t => t.BrokerManifestFileId).HasColumnName("BrokerManifestFileId");
            this.Property(t => t.CarrierManifestFileId).HasColumnName("CarrierManifestFileId");

            // Relationships
            this.HasRequired(t => t.Site)
                .WithMany(t => t.Shipments)
                .HasForeignKey(d => d.SiteId);
            this.HasOptional(t => t.ShippingParty)
                .WithMany(t => t.Shipments)
                .HasForeignKey(d => d.ConsigneePartyId);
            this.HasOptional(t => t.ShippingParty1)
                .WithMany(t => t.Shipments1)
                .HasForeignKey(d => d.ShipperPartyId);

        }
    }
}
