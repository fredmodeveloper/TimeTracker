using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ProjectName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Project");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.ProjectPlatformID).HasColumnName("ProjectPlatformID");
        }
    }
}
