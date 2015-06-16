using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UMElasticWebsite.DomainDTO;
using RecruiteeService;
using JobService;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IServiceWCF
{	
    #region Task
 
    [OperationContract]
    List<TaskDto> selectAllTask();

    [OperationContract]
    TaskDto selectTaskById(TaskDto obj);

    [OperationContract]
    Boolean insertTask(TaskDto obj);

    [OperationContract]
    Boolean updateTask(TaskDto obj);

    [OperationContract]
    Boolean deleteTask(TaskDto obj);
 
    #endregion

    #region Recruitee

    [OperationContract]
    List<RecruiteeDto> selectAllRecruitee();

    [OperationContract]
    RecruiteeDto selectRecruiteeById(RecruiteeDto obj);

    [OperationContract]
    Boolean insertRecruitee(RecruiteeDto obj);

    [OperationContract]
    Boolean updateRecruitee(RecruiteeDto obj);

    [OperationContract]
    Boolean deleteRecruitee(RecruiteeDto obj);

    #endregion

    #region Job

    [OperationContract]
    List<JobDto> selectAllJob();

    [OperationContract]
    JobDto selectJobById(JobDto obj);

    [OperationContract]
    Boolean insertJob(JobDto obj);

    [OperationContract]
    Boolean updateJob(JobDto obj);

    [OperationContract]
    Boolean deleteJob(JobDto obj);

    #endregion
}
