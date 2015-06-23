using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElasticServiceMobile;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceMobileClient svc = new ServiceMobileClient();

        RecruiteeDto[] arr = svc.selectAllRecruitee();

        Boolean result = svc.addSkillToRecruitee(arr[0].RecruiteeId.ToString(), "SKI01");
        
    }
}