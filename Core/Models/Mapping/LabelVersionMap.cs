using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class LabelVersionMap : EntityTypeConfiguration<LabelVersion>
    {
        public LabelVersionMap()
        {
            // Primary Key
            this.HasKey(t => t.LabelVersionId);

            // Properties
            this.Property(t => t.LabelVersionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LabelVersions");
            this.Property(t => t.LabelVersionId).HasColumnName("LabelVersionId");
            this.Property(t => t.LabelId).HasColumnName("LabelId");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.LabelText).HasColumnName("LabelText");
        }
    }
}
