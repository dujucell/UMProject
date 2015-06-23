using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMElasticWebsite.Service.Interface;
using UMElasticWebsite.Exceptions.Service;
using RecruiteeService;

namespace UMElasticWebsite.Business
{
    public class RecruiteeManager : BusinessManager
    {

        public List<RecruiteeDto> selectAllRecruitee()
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.selectAllRecruitee();
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public RecruiteeDto selectRecruiteeById(RecruiteeDto obj)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.selectRecruiteeById(obj);
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Boolean insertRecruitee(RecruiteeDto obj)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.insertRecruitee(obj);

            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean updateRecruitee(RecruiteeDto obj)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.updateRecruitee(obj);

            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean deleteRecruitee(RecruiteeDto obj)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.deleteRecruitee(obj);
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public RecruiteeDto createRecruiteeDTO(System.Guid RecruiteeId, String RankingId)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.createRecruiteeDTO(RecruiteeId, RankingId);
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Boolean addSkillToRecruitee(System.Guid RecruiteeId, String RankingId)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.addSkillToRecruitee(RecruiteeId, RankingId);
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }


    }
       
}
