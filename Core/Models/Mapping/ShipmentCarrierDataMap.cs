using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ShipmentCarrierDataMap : EntityTypeConfiguration<ShipmentCarrierData>
    {
        public ShipmentCarrierDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ShipmentCarrierDataId);

            // Properties
            this.Property(t => t.ShipmentCarrierDataId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FieldName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FieldValue)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ShipmentCarrierData");
            this.Property(t => t.ShipmentCarrierDataId).HasColumnName("ShipmentCarrierDataId");
            this.Property(t => t.ShipmentId).HasColumnName("ShipmentId");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.FieldValue).HasColumnName("FieldValue");

            // Relationships
            this.HasRequired(t => t.Shipment)
                .WithMany(t => t.ShipmentCarrierDatas)
                .HasForeignKey(d => d.ShipmentId);

        }
    }
}
