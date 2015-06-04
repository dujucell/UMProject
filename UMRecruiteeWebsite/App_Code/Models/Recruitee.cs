using System;
using System.Collections.Generic;

namespace UMRecruiteeWebsite.Models
{
    public partial class Recruitee
    {
        public Recruitee()
        {
            this.Categories = new List<Category>();
            this.Skills = new List<Skill>();
        }

        public System.Guid RecruiteeId { get; set; }
        public string RankingId { get; set; }
        public virtual Ranking Ranking { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }

        public static Recruitee createRecruitee(System.Guid RecruiteeId, String RankingId)
        {
            Recruitee obj = new Recruitee();
            obj.RecruiteeId = RecruiteeId;
            obj.RankingId = RankingId;
            return obj;
        }
    }
}
