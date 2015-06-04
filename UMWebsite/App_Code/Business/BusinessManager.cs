using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UMWebsite.Service.Interface;
using UMWebsite.Service;

namespace UMWebsite.Business
{
    public abstract class BusinessManager
    {
        protected IService getService(String name)
        {
            return (Factory.getInstance()).getService(name);
        }
    }
}
