using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ShipmentItemMap : EntityTypeConfiguration<ShipmentItem>
    {
        public ShipmentItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ShipmentId, t.ItemId });

            // Properties
            this.Property(t => t.ShipmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CountryOfOrigin)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ShipmentItems");
            this.Property(t => t.ShipmentId).HasColumnName("ShipmentId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.CountryOfOrigin).HasColumnName("CountryOfOrigin");

            // Relationships
            this.HasRequired(t => t.Shipment)
                .WithMany(t => t.ShipmentItems)
                .HasForeignKey(d => d.ShipmentId);

        }
    }
}
