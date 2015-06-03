using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMProjectWebsite.Service.Interface;
using MLApp;
using UMProjectWebsite.Business;

/// <summary>
/// Summary description for MatlabSvcImpl
/// </summary>
/// 
namespace UMProjectWebsite.Service.Plugin
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