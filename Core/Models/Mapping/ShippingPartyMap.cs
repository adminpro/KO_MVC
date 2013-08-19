using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class ShippingPartyMap : EntityTypeConfiguration<ShippingParty>
    {
        public ShippingPartyMap()
        {
            // Primary Key
            this.HasKey(t => t.ShippingPartyId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.PostalCode)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Telephone)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ShippingParties");
            this.Property(t => t.ShippingPartyId).HasColumnName("ShippingPartyId");
            this.Property(t => t.ShippingPartyTypeId).HasColumnName("ShippingPartyTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.Email).HasColumnName("Email");

            // Relationships
            this.HasOptional(t => t.ShippingPartyType)
                .WithMany(t => t.ShippingParties)
                .HasForeignKey(d => d.ShippingPartyTypeId);

        }
    }
}
