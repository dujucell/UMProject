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
        public void MapDirectoryPath()
        {
            IFileSystemSvc svcFileSystem = (IFileSystemSvc)this.getService(typeof(IFileSystemSvc).Name);
        }
    }
}