using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMJobWebsite.Models;
using System.Runtime.Serialization;

namespace UMJobWebsite.DomainDTO
{
    [DataContract]
    public class SkillDto
    {
        [DataMember]
        public string SkillId { get; set; }

        [DataMember]
        public string SkillName { get; set; }

        public static SkillDto createSkillDTO(Skill obj)
        {
            SkillDto skill = new SkillDto();
            skill.SkillId = obj.SkillId;
            skill.SkillName = obj.SkillName;
            return skill;
        }

        public static SkillDto createSkillDTO(String SkillId, String SkillName)
        {
            SkillDto skill = new SkillDto();
            skill.SkillId = SkillId;
            skill.SkillName = SkillName;
            return skill;
        }
    }
}