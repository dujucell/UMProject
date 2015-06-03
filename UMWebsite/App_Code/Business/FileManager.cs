using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMProjectWebsite.Service.Interface;

/// <summary>
/// Summary description for FactoryManager
/// </summary>

namespace UMProjectWebsite.Business
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