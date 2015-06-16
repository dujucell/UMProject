using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UMElasticWebsite.DomainDTO;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceMobile" in both code and config file together.
[ServiceContract]
public interface IServiceMobile
{
    #region Task
    [OperationContract]
    List<TaskDto> selectAllTask();

    [OperationContract]
    TaskDto selectTaskById(System.Guid TaskId);

    [OperationContract]
    Boolean insertTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription);

    [OperationContract]
    Boolean updateTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription);

    [OperationContract]
    Boolean deleteTask(System.Guid TaskId, System.Guid JobId, System.Guid RecruiteeId, String TaskDescription);
    #endregion

   
}

