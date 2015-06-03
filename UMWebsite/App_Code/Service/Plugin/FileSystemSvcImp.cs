﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMProjectWebsite.Service.Interface;

/// <summary>
/// Summary description for FileSystemSvcImp
/// </summary>
namespace UMProjectWebsite.Service.Plugin
{
    public class FileSystemSvcImp : IFileSystemSvc
    {
        public FileSystemSvcImp()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string MapDirectoryPath(string name)
        {
            return HttpContext.Current.Server.MapPath("~/") + name;
        }
    }

}