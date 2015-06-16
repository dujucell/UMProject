using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UMElasticWebsite.Business;
using UMElasticWebsite.DomainDTO;
using UMElasticWebsite.Models;
using System.ServiceModel.Activation;
using RecruiteeService;
using JobService;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceMobile" in code, svc and config file together.
public class ServiceMobile : IServiceMobile
{
    #region Task

    public List<TaskDto> selectAllTask()
    {
        TaskManager mgr = new TaskManager();
        List<Task> taskList = mgr.selectAllTask();
        List<TaskDto> dtoList = new List<TaskDto>();

        foreach (Task task in taskList)
        {
            dtoList.Add(TaskDto.createTaskDTO(task));
        }

        return dtoList;
    }

    public TaskDto selectTaskById(System.Guid TaskId)
    {
        TaskManager mgr = new TaskManager();
        Task obj = new Task();
        obj.TaskId = TaskId;
        obj = mgr.selectTaskById(obj);
        if (obj != null)
        {
            return TaskDto.createTaskDTO(obj);
        }
        else
        {
            return null;
        }
    }

    public Boolean insertTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription)
    {
        Task obj = Task.createTask(TaskId, JobId, RecruiteeId, TaskDescription);
        TaskManager mgr = new TaskManager();
        return mgr.insertTask(obj);
    }

    public Boolean updateTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription)
    {
        Task obj = Task.createTask(TaskId, JobId, RecruiteeId, TaskDescription);
        TaskManager mgr = new TaskManager();
        return mgr.updateTask(obj);
    }

    public Boolean deleteTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription)
    {
        Task obj = Task.createTask(TaskId, JobId, RecruiteeId, TaskDescription);
        TaskManager mgr = new TaskManager();
        return mgr.deleteTask(obj);
    }
    #endregion

    #region Recruitee

    public List<RecruiteeDto> selectAllRecruitee()
    {
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.selectAllRecruitee();
    }

    public RecruiteeDto selectRecruiteeById(System.Guid RecruiteeId)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        RecruiteeDto obj = new RecruiteeDto();
        obj.RecruiteeId = RecruiteeId;
        return mgr.selectRecruiteeById(obj);
    }

    public Boolean insertRecruitee(System.Guid RecruiteeId, String RankingId)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        RecruiteeDto obj = RecruiteeDto.createRecruiteeDTO(RecruiteeId, RankingId);
        return mgr.insertRecruitee(obj);
    }

    public Boolean updateRecruitee(System.Guid RecruiteeId, String RankingId)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        RecruiteeDto obj = RecruiteeDto.createRecruiteeDTO(RecruiteeId, RankingId);
        return mgr.updateRecruitee(obj);
    }

    public Boolean deleteRecruitee(System.Guid RecruiteeId, String RankingId)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        RecruiteeDto obj = RecruiteeDto.createRecruiteeDTO(RecruiteeId, RankingId);
        return mgr.deleteRecruitee(obj);
    }

    #endregion

    #region Job

    public List<JobDto> selectAllJob()
    {
        JobManager mgr = new JobManager();
        return mgr.selectAllJob();
    }

    public JobDto selectJobById(System.Guid JobId)
    {
        JobManager mgr = new JobManager();
        JobDto obj = new JobDto();
        obj.JobId = JobId;
        return mgr.selectJobById(obj);
    }

    public Boolean insertJob(System.Guid JobId, String JobName, String CompensationId, System.Guid EmployerId,
                                    String JobDescription, int JobQuota, String JobExperienceLevel, decimal JobCompensationValue)
    {
        JobManager mgr = new JobManager();
        JobDto obj = new JobDto();
        obj.JobId = JobId;
        obj.JobName = JobName;
        obj.CompensationId = CompensationId;
        obj.EmployerId = EmployerId;
        obj.JobDescription = JobDescription;
        obj.JobQuota = JobQuota;
        obj.JobExperienceLevel = JobExperienceLevel;
        obj.JobCompensationValue = JobCompensationValue;
        return mgr.insertJob(obj);
    }

    public Boolean updateJob(System.Guid JobId, String JobName, String CompensationId, System.Guid EmployerId,
                                    String JobDescription, int JobQuota, String JobExperienceLevel, decimal JobCompensationValue)
    {
        JobManager mgr = new JobManager();
        JobDto obj = new JobDto();
        obj.JobId = JobId;
        obj.JobName = JobName;
        obj.CompensationId = CompensationId;
        obj.EmployerId = EmployerId;
        obj.JobDescription = JobDescription;
        obj.JobQuota = JobQuota;
        obj.JobExperienceLevel = JobExperienceLevel;
        obj.JobCompensationValue = JobCompensationValue;
        return mgr.updateJob(obj);
    }

    public Boolean deleteJob(System.Guid JobId, String JobName, String CompensationId, System.Guid EmployerId,
                                    String JobDescription, int JobQuota, String JobExperienceLevel, decimal JobCompensationValue)
    {
        JobManager mgr = new JobManager();
        JobDto obj = new JobDto();
        obj.JobId = JobId;
        obj.JobName = JobName;
        obj.CompensationId = CompensationId;
        obj.EmployerId = EmployerId;
        obj.JobDescription = JobDescription;
        obj.JobQuota = JobQuota;
        obj.JobExperienceLevel = JobExperienceLevel;
        obj.JobCompensationValue = JobCompensationValue;
        return mgr.deleteJob(obj);
    }

    #endregion

}
