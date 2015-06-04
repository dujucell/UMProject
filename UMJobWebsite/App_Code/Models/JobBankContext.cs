using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UMWebsite.Models.Mapping;

namespace UMWebsite.Models
{
    public partial class JobBankContext : DbContext
    {
        static JobBankContext()
        {
            Database.SetInitializer<JobBankContext>(null);
        }

        public JobBankContext()
            : base("Name=JobBankContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Compensation> Compensations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CompensationMap());
            modelBuilder.Configurations.Add(new EmployerMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
