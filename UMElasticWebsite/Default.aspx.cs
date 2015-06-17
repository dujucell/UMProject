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

        //RecruiteeManager mgr = new RecruiteeManager();
        //RecruiteeDto rec = mgr.createRecruiteeDTO(new Guid("B5C5E028-9ACC-49AC-BAE7-DC2DBD09FBDC"), "RAN02");

        //Boolean result_insert = mgr.insertRecruitee(rec);

        //List<RecruiteeDto> list_rec = mgr.selectAllRecruitee();

        //RecruiteeDto rec_select = mgr.selectRecruiteeById(rec);

        //rec.RankingId = "RAN01";
        //Boolean result_update = mgr.updateRecruitee(rec);

        //rec_select = mgr.selectRecruiteeById(rec);

        //Boolean result_delete = mgr.deleteRecruitee(rec);

        //rec_select = mgr.selectRecruiteeById(rec);

        //JobManager mgr = new JobManager();
        //Guid id = Guid.NewGuid();
        //JobDto job = mgr.createJobDTO(new Guid("367b72e8-98b5-45da-9918-6e774f525e89"), "Job name", "COMP9",
        //    new Guid("3936A544-59C3-401D-814B-D29C775A81AE"), "Job description", 12, "Job level", 0);

        //Boolean result_insert = mgr.insertJob(job);

        //List<JobDto> list_job = mgr.selectAllJob();

        //JobDto job_select1 = mgr.selectJobById(job);

        //job.JobDescription = "DESCRIPTION 2";
        //Boolean result_update = mgr.updateJob(job);

        //JobDto job_select2 = mgr.selectJobById(job);

        //Boolean result_delete = mgr.deleteJob(job);

        //JobDto job_select3 = mgr.selectJobById(job);
       
    }
}