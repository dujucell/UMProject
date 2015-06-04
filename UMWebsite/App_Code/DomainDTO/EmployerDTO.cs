﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using UMWebsite.Models;

namespace UMWebsite.DomainDTO
{
    [DataContract]
    public class EmployerDto
    {
        [DataMember]
        public System.Guid EmployerId { get; set; }

        [DataMember]
        public string EmployerName { get; set; }

       
    
       public static EmployerDto createEmployerDTO(Employer obj)
        {
            EmployerDto emp = new EmployerDto();
            emp.EmployerId = obj.EmployerId;
            emp.EmployerName = obj.EmployerName;
            return emp;
        }

       public static EmployerDto createEmployerDTO(System.Guid EmployerId, String EmployerName)
        {
            EmployerDto emp = new EmployerDto();
            emp.EmployerId = EmployerId;
            emp.EmployerName = EmployerName;
            return emp;
        }
    }
}