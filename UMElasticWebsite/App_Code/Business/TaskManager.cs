﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMElasticWebsite.Models;
using UMElasticWebsite.Service.Interface;
using UMElasticWebsite.Exceptions.Service;

namespace UMElasticWebsite.Business
{
    public class TaskManager : BusinessManager
    {

        public List<Task> selectAllTask()
        {
            try
            {
                ITaskSvc svc = (ITaskSvc)this.getService(typeof(ITaskSvc).Name);
                return svc.selectAllTask();
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Task selectTaskById(Task obj)
        {
            try
            {
                ITaskSvc svc = (ITaskSvc)this.getService(typeof(ITaskSvc).Name);
                return svc.selectTaskById(obj);
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Boolean insertTask(Task obj)
        {
            try
            {
                ITaskSvc svc = (ITaskSvc)this.getService(typeof(ITaskSvc).Name);
                return svc.insertTask(obj);                   
              
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean updateTask(Task obj)
        {
            try
            {
                ITaskSvc svc = (ITaskSvc)this.getService(typeof(ITaskSvc).Name);
                return svc.updateTask(obj);
               
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean deleteTask(Task obj)
        {
            try
            {
                ITaskSvc svc = (ITaskSvc)this.getService(typeof(ITaskSvc).Name);
                return svc.deleteTask(obj);
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }
    }
}
