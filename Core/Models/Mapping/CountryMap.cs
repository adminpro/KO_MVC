using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.Iso);

            // Properties
            this.Property(t => t.Iso)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.CountryPrintableName)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Iso3)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.PrimaryLanguage)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Countries");
            this.Property(t => t.Iso).HasColumnName("Iso");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.CountryPrintableName).HasColumnName("CountryPrintableName");
            this.Property(t => t.Iso3).HasColumnName("Iso3");
            this.Property(t => t.NumCode).HasColumnName("NumCode");
            this.Property(t => t.PostalCodeNeeded).HasColumnName("PostalCodeNeeded");
            this.Property(t => t.PrimaryLanguage).HasColumnName("PrimaryLanguage");
        }
    }
}
