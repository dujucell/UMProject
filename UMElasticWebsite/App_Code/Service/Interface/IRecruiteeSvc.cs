using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecruiteeService;


namespace UMElasticWebsite.Service.Interface
{
    public interface IRecruiteeSvc : IService
    {
        List<RecruiteeDto> selectAllRecruitee();
        RecruiteeDto selectRecruiteeById(RecruiteeDto obj);
        Boolean insertRecruitee(RecruiteeDto obj);
        Boolean updateRecruitee(RecruiteeDto obj);
        Boolean deleteRecruitee(RecruiteeDto obj);
    }
}