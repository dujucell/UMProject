using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for IFileSystemSVC
/// </summary>
namespace UMProjectWebsite.Service.Interface
{
    
    public interface IFileSystemSvc : IService
    {
        public string MapDirectoryPath(string name); 
        
        
        
    }
}