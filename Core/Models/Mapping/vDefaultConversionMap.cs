using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vDefaultConversionMap : EntityTypeConfiguration<vDefaultConversion>
    {
        public vDefaultConversionMap()
        {
            // Primary Key
            this.HasKey(t => t.ConversionRate);

            // Properties
            this.Property(t => t.FromUnitCode)
                .HasMaxLength(200);

            this.Property(t => t.ToUnitCode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("vDefaultConversions");
            this.Property(t => t.FromUnitCode).HasColumnName("FromUnitCode");
            this.Property(t => t.ToUnitCode).HasColumnName("ToUnitCode");
            this.Property(t => t.ConversionRate).HasColumnName("ConversionRate");
        }
    }
}
