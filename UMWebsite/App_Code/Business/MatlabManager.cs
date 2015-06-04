using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMWebsite.Service.Interface;
/// <summary>
/// Summary description for MatlabManager
/// </summary>
/// 

namespace UMWebsite.Business
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