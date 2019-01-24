using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TimeTracker.Models.Mapping;

namespace TimeTracker.Models
{
    public partial class TimeTrackerDBContext : DbContext
    {
        static TimeTrackerDBContext()
        {
            Database.SetInitializer<TimeTrackerDBContext>(null);
        }

        public TimeTrackerDBContext()
            : base("Name=TimeTrackerDBContext")
        {
        }

        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeTracking> TimeTrackings { get; set; }
        public DbSet<TrackingInvoice> TrackingInvoices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlatformMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new TimeTrackingMap());
            modelBuilder.Configurations.Add(new TrackingInvoiceMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserProjectMap());
        }
    }
}
