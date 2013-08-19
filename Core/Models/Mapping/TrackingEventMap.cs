using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class TrackingEventMap : EntityTypeConfiguration<TrackingEvent>
    {
        public TrackingEventMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackingEventId);

            // Properties
            this.Property(t => t.eShopWorldReferenceNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CarrierReferenceNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EventCode)
                .HasMaxLength(20);

            this.Property(t => t.EventCodeDesc)
                .HasMaxLength(50);

            this.Property(t => t.EventLocation)
                .HasMaxLength(50);

            this.Property(t => t.Signatory)
                .HasMaxLength(50);

            this.Property(t => t.AccountNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrackingEvents");
            this.Property(t => t.TrackingEventId).HasColumnName("TrackingEventId");
            this.Property(t => t.eShopWorldReferenceNo).HasColumnName("eShopWorldReferenceNo");
            this.Property(t => t.CarrierReferenceNo).HasColumnName("CarrierReferenceNo");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.EventCode).HasColumnName("EventCode");
            this.Property(t => t.EventCodeDesc).HasColumnName("EventCodeDesc");
            this.Property(t => t.EventDateTime).HasColumnName("EventDateTime");
            this.Property(t => t.EventLocation).HasColumnName("EventLocation");
            this.Property(t => t.Signatory).HasColumnName("Signatory");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
        }
    }
}
