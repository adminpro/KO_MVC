using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyId);

            // Properties
            this.Property(t => t.CompanyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Companies");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.RetailerId).HasColumnName("RetailerId");
        }
    }
}
