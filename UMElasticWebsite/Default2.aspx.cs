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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //RankingManager mgr = new RankingManager();
        //List<RankingDto> list = mgr.selectAllRanking();

        //RankingDto obj = new RankingDto();
        //obj.RankingId = "RAN01";
        //obj = mgr.selectRankingById(obj);

        SkillRecruiteeManager mgr = new SkillRecruiteeManager();
        List<RecruiteeService.SkillDto> list = mgr.selectAllSkill();

        //RankingDto obj = new RankingDto();
        //obj.RankingId = "RAN01";
        //obj = mgr.selectRankingById(obj);


    }
}