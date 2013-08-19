using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ConversionRateMap : EntityTypeConfiguration<ConversionRate>
    {
        public ConversionRateMap()
        {
            // Primary Key
            this.HasKey(t => t.ConversionRateId);

            // Properties
            this.Property(t => t.ConversionRateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ConversionRates");
            this.Property(t => t.ConversionRateId).HasColumnName("ConversionRateId");
            this.Property(t => t.FromMeasureUnitId).HasColumnName("FromMeasureUnitId");
            this.Property(t => t.ToMeasureUnitId).HasColumnName("ToMeasureUnitId");
            this.Property(t => t.ConversionRate1).HasColumnName("ConversionRate");

            // Relationships
            this.HasRequired(t => t.MeasureUnit)
                .WithMany(t => t.ConversionRates)
                .HasForeignKey(d => d.FromMeasureUnitId);
            this.HasRequired(t => t.MeasureUnit1)
                .WithMany(t => t.ConversionRates1)
                .HasForeignKey(d => d.ToMeasureUnitId);

        }
    }
}
