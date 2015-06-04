using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for IFileSystemSVC
/// </summary>
namespace UMPWebsite.Service.Interface
{
    
    public interface IFileSystemSvc : IService
    {
        public string MapDirectoryPath(string name); 
        
        
    }
}