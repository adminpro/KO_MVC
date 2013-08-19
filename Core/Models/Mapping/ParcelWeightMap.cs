using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ParcelWeightMap : EntityTypeConfiguration<ParcelWeight>
    {
        public ParcelWeightMap()
        {
            // Primary Key
            this.HasKey(t => t.ParcelWeightId);

            // Properties
            this.Property(t => t.ParcelWeightId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeightUnit)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ParcelWeights");
            this.Property(t => t.ParcelWeightId).HasColumnName("ParcelWeightId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.FromWeight).HasColumnName("FromWeight");
            this.Property(t => t.ToWeight).HasColumnName("ToWeight");
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit");

            // Relationships
            this.HasOptional(t => t.Site)
                .WithMany(t => t.ParcelWeights)
                .HasForeignKey(d => d.SiteId);

        }
    }
}
