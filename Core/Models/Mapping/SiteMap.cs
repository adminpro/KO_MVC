using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class SiteMap : EntityTypeConfiguration<Site>
    {
        public SiteMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteId);

            // Properties
            this.Property(t => t.SiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sites");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Sites)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
