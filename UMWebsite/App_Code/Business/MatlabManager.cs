using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMProjectWebsite.Service.Interface;
/// <summary>
/// Summary description for MatlabManager
/// </summary>
/// 

namespace UMProjectWebsite.Business
{
    public class MatlabManager : BusinessManager
    {
        public void MatlabExecute()
        {
            IMatlabSvc svcMatlab = (IMatlabSvc)this.getService(typeof(IMatlabSvc).Name);
            svcMatlab.MatlabExecute();
        }
    }
}