using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using UMWebsite.Models.Mapping;

namespace UMWebsite.Models
{
    public partial class RecruiteeBankContext : DbContext
    {
        static RecruiteeBankContext()
        {
            Database.SetInitializer<RecruiteeBankContext>(null);
        }

        public RecruiteeBankContext()
            : base("Name=RecruiteeBankContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Recruitee> Recruitees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new RankingMap());
            modelBuilder.Configurations.Add(new RecruiteeMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
