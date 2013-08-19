using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            // Primary Key
            this.HasKey(t => t.SettingId);

            // Properties
            this.Property(t => t.SettingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SettingType)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Settings");
            this.Property(t => t.SettingId).HasColumnName("SettingId");
            this.Property(t => t.SettingType).HasColumnName("SettingType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
