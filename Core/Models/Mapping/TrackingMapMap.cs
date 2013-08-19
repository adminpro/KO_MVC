using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class TrackingMapMap : EntityTypeConfiguration<TrackingMap>
    {
        public TrackingMapMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackingMapId);

            // Properties
            this.Property(t => t.EswCode)
                .HasMaxLength(20);

            this.Property(t => t.CarrierCode)
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TrackingMap");
            this.Property(t => t.TrackingMapId).HasColumnName("TrackingMapId");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.EswCode).HasColumnName("EswCode");
            this.Property(t => t.CarrierCode).HasColumnName("CarrierCode");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
