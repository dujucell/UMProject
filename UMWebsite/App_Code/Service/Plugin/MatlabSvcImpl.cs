using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMWebsite.Service.Interface;
using MLApp;
using UMWebsite.Business;

/// <summary>
/// Summary description for MatlabSvcImpl
/// </summary>
/// 
namespace UMWebsite.Service.Plugin
{
    public class MatlabSvcImpl : IMatlabSvc
    {
        private MLApp.MLApp matlab = null;

        public MatlabSvcImpl(string directory)
        {
            this.matlab = new MLApp.MLApp();
        }

        public void MatlabExecute()
        {
            this.matlab.Execute(@"cd " + (new FileManager()).MapDirectoryPath(Constants.CustomDirectories.MATLAB_WORKSPACE));
        }


    }
}