using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Core.Models.Mapping;

namespace Core.Models
{
    public partial class CmsContext : DbContext
    {
        static CmsContext()
        {
            Database.SetInitializer<CmsContext>(null);
        }

        public CmsContext()
            : base("Name=CmsConnectionString")
        {
        }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ConversionRate> ConversionRates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<LabelTemplate> LabelTemplates { get; set; }
        public DbSet<LabelVersion> LabelVersions { get; set; }
        public DbSet<MeasureUnit> MeasureUnits { get; set; }
        public DbSet<ParcelPrice> ParcelPrices { get; set; }
        public DbSet<ParcelSizeRange> ParcelSizeRanges { get; set; }
        public DbSet<ParcelSize> ParcelSizes { get; set; }
        public DbSet<ParcelWeight> ParcelWeights { get; set; }
        public DbSet<RoutingRule> RoutingRules { get; set; }
        public DbSet<RulesLabel> RulesLabels { get; set; }
        public DbSet<ServiceLevel> ServiceLevels { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShipmentCarrierData> ShipmentCarrierDatas { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShippingParty> ShippingParties { get; set; }
        public DbSet<ShippingPartyType> ShippingPartyTypes { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TimeRanx> TimeRanges { get; set; }
        public DbSet<TrackingEvent> TrackingEvents { get; set; }
        public DbSet<TrackingMap> TrackingMaps { get; set; }
        public DbSet<vConversionRate> vConversionRates { get; set; }
        public DbSet<vDefaultConversion> vDefaultConversions { get; set; }
        public DbSet<vParcelSize> vParcelSizes { get; set; }
        public DbSet<vParcelWeight> vParcelWeights { get; set; }
        public DbSet<vRoutingRule> vRoutingRules { get; set; }
        public DbSet<vShipment> vShipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarrierMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new ConversionRateMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DayMap());
            modelBuilder.Configurations.Add(new LabelTemplateMap());
            modelBuilder.Configurations.Add(new LabelVersionMap());
            modelBuilder.Configurations.Add(new MeasureUnitMap());
            modelBuilder.Configurations.Add(new ParcelPriceMap());
            modelBuilder.Configurations.Add(new ParcelSizeRangeMap());
            modelBuilder.Configurations.Add(new ParcelSizeMap());
            modelBuilder.Configurations.Add(new ParcelWeightMap());
            modelBuilder.Configurations.Add(new RoutingRuleMap());
            modelBuilder.Configurations.Add(new RulesLabelMap());
            modelBuilder.Configurations.Add(new ServiceLevelMap());
            modelBuilder.Configurations.Add(new SettingMap());
            modelBuilder.Configurations.Add(new ShipmentCarrierDataMap());
            modelBuilder.Configurations.Add(new ShipmentItemMap());
            modelBuilder.Configurations.Add(new ShipmentMap());
            modelBuilder.Configurations.Add(new ShippingPartyMap());
            modelBuilder.Configurations.Add(new ShippingPartyTypeMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TimeRanxMap());
            modelBuilder.Configurations.Add(new TrackingEventMap());
            modelBuilder.Configurations.Add(new TrackingMapMap());
            modelBuilder.Configurations.Add(new vConversionRateMap());
            modelBuilder.Configurations.Add(new vDefaultConversionMap());
            modelBuilder.Configurations.Add(new vParcelSizeMap());
            modelBuilder.Configurations.Add(new vParcelWeightMap());
            modelBuilder.Configurations.Add(new vRoutingRuleMap());
            modelBuilder.Configurations.Add(new vShipmentMap());
        }
    }
}
