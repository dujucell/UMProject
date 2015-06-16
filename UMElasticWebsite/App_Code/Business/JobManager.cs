using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMElasticWebsite.Service.Interface;
using UMElasticWebsite.Exceptions.Service;
using JobService;

namespace UMElasticWebsite.Business
{
    public class JobManager : BusinessManager
    {

        public List<JobDto> selectAllJob()
        {
            try
            {
                IJobSvc svc = (IJobSvc)this.getService(typeof(IJobSvc).Name);
                List<JobDto> list = svc.selectAllJob();
                return list;
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public JobDto selectJobById(JobDto obj)
        {
            try
            {
                IJobSvc svc = (IJobSvc)this.getService(typeof(IJobSvc).Name);
                return svc.selectJobById(obj);
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Boolean insertJob(JobDto obj)
        {
            try
            {
                IJobSvc svc = (IJobSvc)this.getService(typeof(IJobSvc).Name);
                return svc.insertJob(obj);

            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean updateJob(JobDto obj)
        {
            try
            {
                IJobSvc svc = (IJobSvc)this.getService(typeof(IJobSvc).Name);
                return svc.updateJob(obj);

            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean deleteJob(JobDto obj)
        {
            try
            {
                IJobSvc svc = (IJobSvc)this.getService(typeof(IJobSvc).Name);
                return svc.deleteJob(obj);
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }
    }
       
}
