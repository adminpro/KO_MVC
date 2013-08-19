using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Core.Models.Mapping;
using System;

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
            this.Configuration.LazyLoadingEnabled = false;
        }

        public override int SaveChanges()
        {
            throw new Exception("Your must be use repository of entity SaveChanges with userName argument.");
        }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ShipmentCarrierData> ShipmentCarrierDatas { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShippingParty> ShippingParties { get; set; }
        public DbSet<ShippingPartyType> ShippingPartyTypes { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<TrackingEvent> TrackingEvents { get; set; }
        public DbSet<TrackingMap> TrackingMaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarrierMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new ShipmentCarrierDataMap());
            modelBuilder.Configurations.Add(new ShipmentItemMap());
            modelBuilder.Configurations.Add(new ShipmentMap());
            modelBuilder.Configurations.Add(new ShippingPartyMap());
            modelBuilder.Configurations.Add(new ShippingPartyTypeMap());
            modelBuilder.Configurations.Add(new TrackingEventMap());
            modelBuilder.Configurations.Add(new TrackingMapMap());
        }
    }
}
