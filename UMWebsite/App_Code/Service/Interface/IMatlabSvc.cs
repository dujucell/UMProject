using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IMatlabSvc
/// </summary>

namespace UMWebsite.Service.Interface
{
    public interface IMatlabSvc : IService
    {
        void MatlabExecute();

    }
}