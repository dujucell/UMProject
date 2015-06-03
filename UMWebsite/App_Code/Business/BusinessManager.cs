using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMProjectWebsite.Service.Interface;
using UMProjectWebsite.Service;

namespace UMProjectWebsite.Business
{
    public abstract class BusinessManager
    {
        protected IService getService(String name)
        {
            return (Factory.getInstance()).getService(name);
        }
    }
}
