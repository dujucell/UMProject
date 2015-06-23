﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLApp;
using UMJobWebsite.Business;
using UMJobWebsite.Models;
using UMJobWebsite.DomainDTO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //MLApp.MLApp matlab = new MLApp.MLApp();
        //matlab.Execute(Server.MapPath("~/MATLab"));
        //object result = null;

        //// Call the MATLAB function myfunc
        //matlab.Feval("myfunc", 2, out result, 3.14, 42.0, "world");

        //// Display result 
        //object[] res = result as object[];

        //Label1.Text = res[0] + " " + res[1];
        //JobManager mgr = new JobManager();
        //bool something = mgr.insertJob(Job.createJob(Guid.NewGuid(), "Job name", "COMP9",
        //new Guid("3936A544-59C3-401D-814B-D29C775A81AE"), "Job description", 12, "Job level", 0));
        //List<Job> list = mgr.selectAllJob();

        //ServiceMobile svc = new ServiceMobile();
        //List<SkillDto> list = svc.selectAllSkill();

        //SkillManager mgr = new SkillManager();
        //List<Skill> list2 = mgr.selectAllSkill();

        ServiceMobile svc = new ServiceMobile();
        //Boolean result = svc.addSkillToJob(new Guid("2A8606D9-83DB-43BD-BD6E-974A2130A5BF"), "SKI01");
        //svc.addSkillToJob(new Guid("3395ACCF-73E8-4596-8A00-C36146E1C5F0"), "SKI01");
        //svc.addSkillToJob(new Guid("3495ACCF-73E8-4596-8A00-C36146E1C5F0"), "SKI01");
        //svc.addSkillToJob(new Guid("3495ACCF-73E8-4596-8A00-C36146E1C5F0"), "SKI02");

        List<JobDto> list = svc.selectJobBySkillId("SKI02");



    }
}