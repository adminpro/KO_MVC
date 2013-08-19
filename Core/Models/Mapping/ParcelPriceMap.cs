using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ParcelPriceMap : EntityTypeConfiguration<ParcelPrice>
    {
        public ParcelPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.ParcelPriceId);

            // Properties
            this.Property(t => t.ParcelPriceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Currency)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ParcelPrices");
            this.Property(t => t.ParcelPriceId).HasColumnName("ParcelPriceId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.FromPrice).HasColumnName("FromPrice");
            this.Property(t => t.ToPrice).HasColumnName("ToPrice");
            this.Property(t => t.Currency).HasColumnName("Currency");

            // Relationships
            this.HasOptional(t => t.Site)
                .WithMany(t => t.ParcelPrices)
                .HasForeignKey(d => d.SiteId);

        }
    }
}
