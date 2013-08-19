using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ParcelSizeMap : EntityTypeConfiguration<ParcelSize>
    {
        public ParcelSizeMap()
        {
            // Primary Key
            this.HasKey(t => t.ParcelSizeId);

            // Properties
            this.Property(t => t.ParcelSizeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParcelSizeName)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ParcelSizes");
            this.Property(t => t.ParcelSizeId).HasColumnName("ParcelSizeId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.ParcelSizeName).HasColumnName("ParcelSizeName");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Unit).HasColumnName("Unit");

            // Relationships
            this.HasOptional(t => t.Site)
                .WithMany(t => t.ParcelSizes)
                .HasForeignKey(d => d.SiteId);

        }
    }
}
