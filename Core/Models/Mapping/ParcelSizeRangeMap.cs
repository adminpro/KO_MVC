using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ParcelSizeRangeMap : EntityTypeConfiguration<ParcelSizeRange>
    {
        public ParcelSizeRangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ParcelSizeRangeId);

            // Properties
            this.Property(t => t.ParcelSizeRangeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ParcelSizeRange");
            this.Property(t => t.ParcelSizeRangeId).HasColumnName("ParcelSizeRangeId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.FromParcelSizeId).HasColumnName("FromParcelSizeId");
            this.Property(t => t.ToParcelSizeId).HasColumnName("ToParcelSizeId");

            // Relationships
            this.HasOptional(t => t.ParcelSize)
                .WithMany(t => t.ParcelSizeRanges)
                .HasForeignKey(d => d.FromParcelSizeId);
            this.HasOptional(t => t.ParcelSize1)
                .WithMany(t => t.ParcelSizeRanges1)
                .HasForeignKey(d => d.ToParcelSizeId);

        }
    }
}
