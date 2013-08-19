using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class vRoutingRuleMap : EntityTypeConfiguration<vRoutingRule>
    {
        public vRoutingRuleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoutingRuleId, t.SiteId, t.DestinationCountryIso, t.PriorityLevel, t.CarrierId, t.CarrierName, t.ServiceLevelId, t.ServiceLevelName, t.ServiceLevelCode, t.DefaultFromWeight, t.DefaultToWeight, t.FromSizeWidth, t.FromSizeLength, t.FromSizeDepth, t.FromSizeVolume, t.ToSizeWidth, t.ToSizeLength, t.ToSizeDepth, t.ToSizeVolume, t.FromPrice, t.ToPrice });

            // Properties
            this.Property(t => t.RoutingRuleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DestinationCountryIso)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PriorityLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CarrierId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CarrierName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ServiceLevelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceLevelName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ServiceLevelCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DefaultWeightUnit)
                .HasMaxLength(200);

            this.Property(t => t.FromSizeUnit)
                .HasMaxLength(200);

            this.Property(t => t.ToSizeUnit)
                .HasMaxLength(200);

            this.Property(t => t.Currency)
                .HasMaxLength(3);

            this.Property(t => t.TimeRangeName)
                .HasMaxLength(50);

            this.Property(t => t.FromTime)
                .HasMaxLength(4);

            this.Property(t => t.ToTime)
                .HasMaxLength(4);

            this.Property(t => t.DaysRuleName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vRoutingRules");
            this.Property(t => t.RoutingRuleId).HasColumnName("RoutingRuleId");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.DestinationCountryIso).HasColumnName("DestinationCountryIso");
            this.Property(t => t.PriorityLevel).HasColumnName("PriorityLevel");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.CarrierName).HasColumnName("CarrierName");
            this.Property(t => t.ServiceLevelId).HasColumnName("ServiceLevelId");
            this.Property(t => t.ServiceLevelName).HasColumnName("ServiceLevelName");
            this.Property(t => t.ServiceLevelCode).HasColumnName("ServiceLevelCode");
            this.Property(t => t.ParcelWeightId).HasColumnName("ParcelWeightId");
            this.Property(t => t.DefaultFromWeight).HasColumnName("DefaultFromWeight");
            this.Property(t => t.DefaultToWeight).HasColumnName("DefaultToWeight");
            this.Property(t => t.DefaultWeightUnit).HasColumnName("DefaultWeightUnit");
            this.Property(t => t.ParcelSizeRangeId).HasColumnName("ParcelSizeRangeId");
            this.Property(t => t.FromSizeWidth).HasColumnName("FromSizeWidth");
            this.Property(t => t.FromSizeLength).HasColumnName("FromSizeLength");
            this.Property(t => t.FromSizeDepth).HasColumnName("FromSizeDepth");
            this.Property(t => t.FromSizeVolume).HasColumnName("FromSizeVolume");
            this.Property(t => t.FromSizeUnit).HasColumnName("FromSizeUnit");
            this.Property(t => t.ToSizeWidth).HasColumnName("ToSizeWidth");
            this.Property(t => t.ToSizeLength).HasColumnName("ToSizeLength");
            this.Property(t => t.ToSizeDepth).HasColumnName("ToSizeDepth");
            this.Property(t => t.ToSizeVolume).HasColumnName("ToSizeVolume");
            this.Property(t => t.ToSizeUnit).HasColumnName("ToSizeUnit");
            this.Property(t => t.ParcelPriceId).HasColumnName("ParcelPriceId");
            this.Property(t => t.FromPrice).HasColumnName("FromPrice");
            this.Property(t => t.ToPrice).HasColumnName("ToPrice");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.TimeRangeId).HasColumnName("TimeRangeId");
            this.Property(t => t.TimeRangeName).HasColumnName("TimeRangeName");
            this.Property(t => t.FromTime).HasColumnName("FromTime");
            this.Property(t => t.ToTime).HasColumnName("ToTime");
            this.Property(t => t.DayId).HasColumnName("DayId");
            this.Property(t => t.DaysRuleName).HasColumnName("DaysRuleName");
            this.Property(t => t.Monday).HasColumnName("Monday");
            this.Property(t => t.Tuesday).HasColumnName("Tuesday");
            this.Property(t => t.Wednesday).HasColumnName("Wednesday");
            this.Property(t => t.Thursday).HasColumnName("Thursday");
            this.Property(t => t.Friday).HasColumnName("Friday");
            this.Property(t => t.Saturday).HasColumnName("Saturday");
            this.Property(t => t.Sunday).HasColumnName("Sunday");
        }
    }
}
