using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class TimeRanxMap : EntityTypeConfiguration<TimeRanx>
    {
        public TimeRanxMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeRangeId);

            // Properties
            this.Property(t => t.TimeRangeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.FromTime)
                .HasMaxLength(4);

            this.Property(t => t.ToTime)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("TimeRanges");
            this.Property(t => t.TimeRangeId).HasColumnName("TimeRangeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.FromTime).HasColumnName("FromTime");
            this.Property(t => t.ToTime).HasColumnName("ToTime");

            // Relationships
            this.HasOptional(t => t.Site)
                .WithMany(t => t.TimeRanges)
                .HasForeignKey(d => d.SiteId);

        }
    }
}
