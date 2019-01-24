using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class UserProjectMap : EntityTypeConfiguration<UserProject>
    {
        public UserProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserProject");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
        }
    }
}
