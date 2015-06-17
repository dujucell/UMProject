using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLApp;
using UMRecruiteeWebsite.Business;
using UMRecruiteeWebsite.Service.Interface;
using UMRecruiteeWebsite.Models;

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
        
        //CategoryManager mgr = new CategoryManager();
        //Category obj = new Category();
        //obj.CategoryId = "CAT01";
        //obj.CategoryName = "bla bla";
        //obj.CategoryDescription = "bla bla";
        //Boolean result = mgr.updateCategory(obj)

        RecruiteeManager mgr = new RecruiteeManager();
        Recruitee obj = new Recruitee();
        //obj.RankingId = "RAN01";
        //obj.RecruiteeId = System.Guid.NewGuid();
     //   Boolean result = mgr.insertRecruitee(obj);

        List<Recruitee> list = mgr.selectAllRecruitee();

       
    }
}