using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class MeasureUnitMap : EntityTypeConfiguration<MeasureUnit>
    {
        public MeasureUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.MeasureUnitId);

            // Properties
            this.Property(t => t.MeasureUnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("MeasureUnits");
            this.Property(t => t.MeasureUnitId).HasColumnName("MeasureUnitId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
        }
    }
}
