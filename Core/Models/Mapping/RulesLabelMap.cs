using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class RulesLabelMap : EntityTypeConfiguration<RulesLabel>
    {
        public RulesLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.RulesLabelsId);

            // Properties
            this.Property(t => t.RulesLabelsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RulesLabels");
            this.Property(t => t.RulesLabelsId).HasColumnName("RulesLabelsId");
            this.Property(t => t.RoutingRuleId).HasColumnName("RoutingRuleId");
            this.Property(t => t.LabelTemplateId).HasColumnName("LabelTemplateId");

            // Relationships
            this.HasRequired(t => t.LabelTemplate)
                .WithMany(t => t.RulesLabels)
                .HasForeignKey(d => d.LabelTemplateId);
            this.HasRequired(t => t.RoutingRule)
                .WithMany(t => t.RulesLabels)
                .HasForeignKey(d => d.RoutingRuleId);

        }
    }
}
