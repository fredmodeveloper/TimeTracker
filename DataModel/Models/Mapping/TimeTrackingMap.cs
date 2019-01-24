using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class TimeTrackingMap : EntityTypeConfiguration<TimeTracking>
    {
        public TimeTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("TimeTracking");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.HourCount).HasColumnName("HourCount");
            this.Property(t => t.MinutesCount).HasColumnName("MinutesCount");
            this.Property(t => t.TrackingInvoiceID).HasColumnName("TrackingInvoiceID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
