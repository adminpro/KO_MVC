using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ServiceLevelMap : EntityTypeConfiguration<ServiceLevel>
    {
        public ServiceLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceLevelId);

            // Properties
            this.Property(t => t.ServiceLevelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ServiceLevels");
            this.Property(t => t.ServiceLevelId).HasColumnName("ServiceLevelId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
        }
    }
}
