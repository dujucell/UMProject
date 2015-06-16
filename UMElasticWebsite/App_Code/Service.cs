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

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service : IServiceWCF
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

    public TaskDto selectTaskById(TaskDto dto)
    {
        TaskManager mgr = new TaskManager();
        Task obj = new Task();
        obj.TaskId = dto.TaskId;
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

    public Boolean insertTask(TaskDto dto)
    {
        Task obj = Task.createTask(dto.TaskId, dto.JobId, dto.RecruiteeId, dto.TaskDescription);
        TaskManager mgr = new TaskManager();
        return mgr.insertTask(obj);
    }

    public Boolean updateTask(TaskDto dto)
    {
        Task obj = Task.createTask(dto.TaskId, dto.JobId, dto.RecruiteeId, dto.TaskDescription);
        TaskManager mgr = new TaskManager();
        return mgr.updateTask(obj);
    }

    public Boolean deleteTask(TaskDto dto)
    {
        Task obj = Task.createTask(dto.TaskId, dto.JobId, dto.RecruiteeId, dto.TaskDescription);
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

    public RecruiteeDto selectRecruiteeById(RecruiteeDto dto)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.selectRecruiteeById(dto);
    }

    public Boolean insertRecruitee(RecruiteeDto dto)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.insertRecruitee(dto);
    }

    public Boolean updateRecruitee(RecruiteeDto dto)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.updateRecruitee(dto);
    }

    public Boolean deleteRecruitee(RecruiteeDto dto)
    {
        RecruiteeManager mgr = new RecruiteeManager();
        return mgr.deleteRecruitee(dto);
    }

    #endregion

    #region Job

    public List<JobDto> selectAllJob()
    {
        JobManager mgr = new JobManager();
        return mgr.selectAllJob();
    }

    public JobDto selectJobById(JobDto dto)
    {
        JobManager mgr = new JobManager();
        return mgr.selectJobById(dto);
    }

    public Boolean insertJob(JobDto dto)
    {
        JobManager mgr = new JobManager();
        return mgr.insertJob(dto);
    }

    public Boolean updateJob(JobDto dto)
    {
        JobManager mgr = new JobManager();
        return mgr.updateJob(dto);
    }

    public Boolean deleteJob(JobDto dto)
    {
        JobManager mgr = new JobManager();
        return mgr.deleteJob(dto);
    }

    #endregion

}