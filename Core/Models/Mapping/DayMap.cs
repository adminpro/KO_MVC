using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Models.Mapping
{
    public class DayMap : EntityTypeConfiguration<Day>
    {
        public DayMap()
        {
            // Primary Key
            this.HasKey(t => t.DayId);

            // Properties
            this.Property(t => t.DayId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Days");
            this.Property(t => t.DayId).HasColumnName("DayId");
            this.Property(t => t.Name).HasColumnName("Name");
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
