using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class LabelTemplateMap : EntityTypeConfiguration<LabelTemplate>
    {
        public LabelTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.LabelTemplateId);

            // Properties
            this.Property(t => t.LabelTemplateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LabelName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LabelTemplates");
            this.Property(t => t.LabelTemplateId).HasColumnName("LabelTemplateId");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.LabelName).HasColumnName("LabelName");
            this.Property(t => t.LabelVersionId).HasColumnName("LabelVersionId");

            // Relationships
            this.HasOptional(t => t.Carrier)
                .WithMany(t => t.LabelTemplates)
                .HasForeignKey(d => d.CarrierId);
            this.HasRequired(t => t.LabelVersion)
                .WithMany(t => t.LabelTemplates)
                .HasForeignKey(d => d.LabelVersionId);

        }
    }
}
