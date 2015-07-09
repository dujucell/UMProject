using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLApp;
using UMRecruiteeWebsite.Business;
using UMRecruiteeWebsite.Service.Interface;
using UMRecruiteeWebsite.Service.Plugin;
using UMRecruiteeWebsite.Models;
using UMRecruiteeWebsite.DomainDTO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Service svc = new Service();
        RecruiteeDto rec = new RecruiteeDto();
        rec.RecruiteeId = new Guid("B5C5E028-9ACC-49AC-BAE7-DC2DBD09FBDD");
        RecruiteeDto rec_select = svc.selectRecruiteeById(rec);
        rec_select.RankingValue = 4.098765;
        bool result = svc.updateRecruitee(rec_select);
    }
}