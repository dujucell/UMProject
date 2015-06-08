using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace UMRecruiteeWebsite.Models.Mapping
{
    public class ExperienceMap : EntityTypeConfiguration<Experience>
    {
        public ExperienceMap()
        {
            // Primary Key
            this.HasKey(t => t.ExperienceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Experience");
            this.Property(t => t.ExperienceId).HasColumnName("ExperienceId");
            this.Property(t => t.RecruiteeId).HasColumnName("RecruiteeId");

            // Relationships
            this.HasOptional(t => t.Recruitee)
                .WithMany(t => t.Experiences)
                .HasForeignKey(d => d.RecruiteeId);

        }
    }
}
