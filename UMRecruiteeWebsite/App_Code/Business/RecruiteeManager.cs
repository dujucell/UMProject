using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMRecruiteeWebsite.Models;
using UMRecruiteeWebsite.Service.Interface;
using UMRecruiteeWebsite.Exceptions.Service;

namespace UMRecruiteeWebsite.Business
{
    public class RecruiteeManager : BusinessManager
    {

        public List<Recruitee> selectAllRecruitee()
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

        public Recruitee selectRecruiteeById(Recruitee obj)
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

        public Boolean insertRecruitee(Recruitee obj)
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

        public Boolean updateRecruitee(Recruitee obj)
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

        public Boolean deleteRecruitee(Recruitee obj)
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

        public Boolean addSkillToRecruitee(Recruitee obj, Skill skill)
        {
            try
            {
                IRecruiteeSvc svc = (IRecruiteeSvc)this.getService(typeof(IRecruiteeSvc).Name);
                return svc.addSkillToRecruitee(obj, skill);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
