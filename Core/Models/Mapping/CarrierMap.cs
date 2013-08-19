using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class CarrierMap : EntityTypeConfiguration<Carrier>
    {
        public CarrierMap()
        {
            // Primary Key
            this.HasKey(t => t.CarrierId);

            // Properties
            this.Property(t => t.CarrierId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CarrierName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CarrierCode)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("Carriers");
            this.Property(t => t.CarrierId).HasColumnName("CarrierId");
            this.Property(t => t.CarrierName).HasColumnName("CarrierName");
            this.Property(t => t.CarrierCode).HasColumnName("CarrierCode");
        }
    }
}
