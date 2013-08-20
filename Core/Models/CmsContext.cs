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
            : base("Name=LocalConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public override int SaveChanges()
        {
            throw new Exception("Your must be use repository of entity SaveChanges with userName argument.");
        }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<TrackingEvent> TrackingEvents { get; set; }
        public DbSet<TrackingMap> TrackingMaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarrierMap());
            modelBuilder.Configurations.Add(new ShipmentMap());
            modelBuilder.Configurations.Add(new TrackingEventMap());
            modelBuilder.Configurations.Add(new TrackingMapMap());
        }
    }
}
