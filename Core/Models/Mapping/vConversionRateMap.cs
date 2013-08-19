using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vConversionRateMap : EntityTypeConfiguration<vConversionRate>
    {
        public vConversionRateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FromUnitCode, t.FromUnitName, t.ToUnitCode, t.ToUnitName, t.ConversionRate });

            // Properties
            this.Property(t => t.FromUnitCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.FromUnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ToUnitCode)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ToUnitName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vConversionRates");
            this.Property(t => t.FromUnitCode).HasColumnName("FromUnitCode");
            this.Property(t => t.FromUnitName).HasColumnName("FromUnitName");
            this.Property(t => t.ToUnitCode).HasColumnName("ToUnitCode");
            this.Property(t => t.ToUnitName).HasColumnName("ToUnitName");
            this.Property(t => t.ConversionRate).HasColumnName("ConversionRate");
        }
    }
}
