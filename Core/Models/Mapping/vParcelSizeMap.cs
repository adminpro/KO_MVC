using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vParcelSizeMap : EntityTypeConfiguration<vParcelSize>
    {
        public vParcelSizeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ParcelSizeId, t.Length, t.Width, t.Depth, t.Volume, t.Unit, t.ConversionRateToDefaultUnit, t.DefaultLength, t.DefaultWidth, t.DefaultDepth, t.DefaultVolume });

            // Properties
            this.Property(t => t.ParcelSizeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParcelSizeName)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DefaultUnit)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("vParcelSizes");
            this.Property(t => t.ParcelSizeId).HasColumnName("ParcelSizeId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.ParcelSizeName).HasColumnName("ParcelSizeName");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ConversionRateToDefaultUnit).HasColumnName("ConversionRateToDefaultUnit");
            this.Property(t => t.DefaultLength).HasColumnName("DefaultLength");
            this.Property(t => t.DefaultWidth).HasColumnName("DefaultWidth");
            this.Property(t => t.DefaultDepth).HasColumnName("DefaultDepth");
            this.Property(t => t.DefaultVolume).HasColumnName("DefaultVolume");
            this.Property(t => t.DefaultUnit).HasColumnName("DefaultUnit");
        }
    }
}
