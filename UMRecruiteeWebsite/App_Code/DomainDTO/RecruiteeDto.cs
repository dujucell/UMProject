using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UMRecruiteeWebsite.Models;

namespace UMRecruiteeWebsite.DomainDTO
{
    [DataContract]
    public class RecruiteeDto
    {
        [DataMember]
        public System.Guid RecruiteeId { get; set; }

        [DataMember]
        public string RankingId { get; set; }

        public static RecruiteeDto createRecruiteeDTO(Recruitee obj)
        {
            RecruiteeDto rec = new RecruiteeDto();
            rec.RecruiteeId = obj.RecruiteeId;
            rec.RankingId = obj.RankingId;
            return rec;
        }

        public static RecruiteeDto createRecruiteeDTO(System.Guid RecruiteeId, String RankingId)
        {
            RecruiteeDto rec = new RecruiteeDto();
            rec.RecruiteeId = RecruiteeId;
            rec.RankingId = RankingId;
            return rec;
        }
    }
}
