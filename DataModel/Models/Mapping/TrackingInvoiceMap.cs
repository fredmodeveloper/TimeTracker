using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class TrackingInvoiceMap : EntityTypeConfiguration<TrackingInvoice>
    {
        public TrackingInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TrackingInvoice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PeriodStartDate).HasColumnName("PeriodStartDate");
            this.Property(t => t.PeriodEndDate).HasColumnName("PeriodEndDate");
            this.Property(t => t.IsPaid).HasColumnName("IsPaid");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
