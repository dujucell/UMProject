﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobService;


namespace UMElasticWebsite.Service.Interface
{
    public interface IJobSvc : IService
    {
        List<JobDto> selectAllJob();
        JobDto selectJobById(JobDto obj);
        Boolean insertJob(JobDto obj);
        Boolean updateJob(JobDto obj);
        Boolean deleteJob(JobDto obj);
        JobDto createJobDTO(System.Guid JobId, String JobName, String CompensationId, System.Guid EmployerId,
                            String JobDescription, int JobQuota, String JobExperienceLevel, decimal JobCompensationValue);
        List<JobDto> selectJobBySkillId(String SkillId);
        Boolean addSkillToJob(JobDto obj, String skillId);
        Boolean removeSkillFromJob(JobDto obj, String skillId);

    }
}