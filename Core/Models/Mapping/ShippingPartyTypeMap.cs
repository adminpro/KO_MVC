using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ShippingPartyTypeMap : EntityTypeConfiguration<ShippingPartyType>
    {
        public ShippingPartyTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ShippingPartyTypeId);

            // Properties
            this.Property(t => t.ShippingPartyTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ShippingPartyTypes");
            this.Property(t => t.ShippingPartyTypeId).HasColumnName("ShippingPartyTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
