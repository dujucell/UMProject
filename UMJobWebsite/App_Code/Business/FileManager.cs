using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMJobWebsite.Service.Interface;


namespace UMJobWebsite.Business
{
    public class FileManager : BusinessManager
    {
        public string MapDirectoryPath(string name)
        {
            IFileSystemSvc svcFileSystem = (IFileSystemSvc)this.getService(typeof(IFileSystemSvc).Name);
            return svcFileSystem.MapDirectoryPath(name);

        }
    }
}