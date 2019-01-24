using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class PlatformMap : EntityTypeConfiguration<Platform>
    {
        public PlatformMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Platform1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Platform");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Platform1).HasColumnName("Platform");
        }
    }
}
