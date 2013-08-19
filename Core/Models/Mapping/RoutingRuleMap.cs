using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class RoutingRuleMap : EntityTypeConfiguration<RoutingRule>
    {
        public RoutingRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoutingRuleId);

            // Properties
            this.Property(t => t.RoutingRuleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DestinationCountryIso)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RoutingRules");
            this.Property(t => t.RoutingRuleId).HasColumnName("RoutingRuleId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.DestinationCountryIso).HasColumnName("DestinationCountryIso");
            this.Property(t => t.ServiceLevelId).HasColumnName("ServiceLevelId");
            this.Property(t => t.PriorityLevel).HasColumnName("PriorityLevel");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.ParcelWeightId).HasColumnName("ParcelWeightId");
            this.Property(t => t.ParcelSizeRangeId).HasColumnName("ParcelSizeRangeId");
            this.Property(t => t.ParcelPriceId).HasColumnName("ParcelPriceId");
            this.Property(t => t.TimeRangeId).HasColumnName("TimeRangeId");
            this.Property(t => t.DayId).HasColumnName("DayId");

            // Relationships
            this.HasRequired(t => t.Carrier)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.CarrierId);
            this.HasOptional(t => t.Day)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.DayId);
            this.HasOptional(t => t.ParcelPrice)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.ParcelPriceId);
            this.HasOptional(t => t.ParcelSizeRange)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.ParcelSizeRangeId);
            this.HasOptional(t => t.ParcelWeight)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.ParcelWeightId);
            this.HasOptional(t => t.ServiceLevel)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.ServiceLevelId);
            this.HasRequired(t => t.Site)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.SiteId);
            this.HasOptional(t => t.TimeRanx)
                .WithMany(t => t.RoutingRules)
                .HasForeignKey(d => d.TimeRangeId);

        }
    }
}
