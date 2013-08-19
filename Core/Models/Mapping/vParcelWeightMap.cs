using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vParcelWeightMap : EntityTypeConfiguration<vParcelWeight>
    {
        public vParcelWeightMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ParcelWeightId, t.FromWeight, t.ToWeight, t.WeightUnit, t.ConversionRateToDefaultUnit, t.DefaultFromWeight, t.DefaultToWeight });

            // Properties
            this.Property(t => t.ParcelWeightId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeightUnit)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DefaultWeightUnit)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("vParcelWeights");
            this.Property(t => t.ParcelWeightId).HasColumnName("ParcelWeightId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.FromWeight).HasColumnName("FromWeight");
            this.Property(t => t.ToWeight).HasColumnName("ToWeight");
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit");
            this.Property(t => t.ConversionRateToDefaultUnit).HasColumnName("ConversionRateToDefaultUnit");
            this.Property(t => t.DefaultFromWeight).HasColumnName("DefaultFromWeight");
            this.Property(t => t.DefaultToWeight).HasColumnName("DefaultToWeight");
            this.Property(t => t.DefaultWeightUnit).HasColumnName("DefaultWeightUnit");
        }
    }
}
