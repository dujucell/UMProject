using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UMElasticWebsite.Business;
using UMElasticWebsite.Models;
using RecruiteeService;
using JobService;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TaskManager mgr = new TaskManager();
        //Task obj = Task.createTask(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "Task description");
        //Boolean result = mgr.insertTask(obj);

        //List<Task> list = mgr.selectAllTask();

        RecruiteeManager mgr = new RecruiteeManager();
        List<RecruiteeDto> listDTO = mgr.selectAllRecruitee();

        JobManager mgrJob = new JobManager();
        List<JobDto> listJob = mgrJob.selectAllJob();
    }
}