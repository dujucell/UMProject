﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMWebsite.Exceptions.Service
{
    public class ServiceLoadException : Exception
    {
        public ServiceLoadException(String message) 
            : base(message)
        {
        }
    }
}