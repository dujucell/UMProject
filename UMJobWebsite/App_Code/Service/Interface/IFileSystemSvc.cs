using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMWebsite.Service.Interface;


namespace UMWebsite.Service.Interface
{
    
    public interface IFileSystemSvc : IService
    {
        string MapDirectoryPath(string name);   
    }
}