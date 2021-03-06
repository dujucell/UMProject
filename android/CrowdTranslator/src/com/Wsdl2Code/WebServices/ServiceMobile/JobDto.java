package com.Wsdl2Code.WebServices.ServiceMobile;

//------------------------------------------------------------------------------
// <wsdl2code-generated>
//    This code was generated by http://www.wsdl2code.com version  2.6
//
// Date Of Creation: 6/24/2015 6:28:23 PM
//    Please dont change this code, regeneration will override your changes
//</wsdl2code-generated>
//
//------------------------------------------------------------------------------
//
//This source code was auto-generated by Wsdl2Code  Version
//
import org.ksoap2.serialization.KvmSerializable;
import org.ksoap2.serialization.PropertyInfo;

import java.io.Serializable;
import java.util.Hashtable;

import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;

public class JobDto implements KvmSerializable, Serializable {
    
    public String compensationId;
    public String employerId;
    public double jobCompensationValue;
    public boolean jobCompensationValueSpecified;
    public String jobDescription;
    public String jobExperienceLevel;
    public String jobId;
    public String jobName;
    public int jobQuota;
    public boolean jobQuotaSpecified;
    
    public JobDto(){}
    
    public JobDto(SoapObject soapObject)
    {
        if (soapObject == null)
            return;
        if (soapObject.hasProperty("CompensationId"))
        {
            Object obj = soapObject.getProperty("CompensationId");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                compensationId = j.toString();
            }else if (obj!= null && obj instanceof String){
                compensationId = (String) obj;
            }
        }
        if (soapObject.hasProperty("EmployerId"))
        {
            Object obj = soapObject.getProperty("EmployerId");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                employerId = j.toString();
            }else if (obj!= null && obj instanceof String){
                employerId = (String) obj;
            }
        }
        if (soapObject.hasProperty("JobCompensationValue"))
        {
            Object obj = soapObject.getProperty("JobCompensationValue");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobCompensationValue = Double.parseDouble(j.toString());
            }else if (obj!= null && obj instanceof Number){
                jobCompensationValue = (Double) obj;
            }
        }
        if (soapObject.hasProperty("JobCompensationValueSpecified"))
        {
            Object obj = soapObject.getProperty("JobCompensationValueSpecified");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobCompensationValueSpecified = Boolean.parseBoolean(j.toString());
            }else if (obj!= null && obj instanceof Boolean){
                jobCompensationValueSpecified = (Boolean) obj;
            }
        }
        if (soapObject.hasProperty("JobDescription"))
        {
            Object obj = soapObject.getProperty("JobDescription");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobDescription = j.toString();
            }else if (obj!= null && obj instanceof String){
                jobDescription = (String) obj;
            }
        }
        if (soapObject.hasProperty("JobExperienceLevel"))
        {
            Object obj = soapObject.getProperty("JobExperienceLevel");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobExperienceLevel = j.toString();
            }else if (obj!= null && obj instanceof String){
                jobExperienceLevel = (String) obj;
            }
        }
        if (soapObject.hasProperty("JobId"))
        {
            Object obj = soapObject.getProperty("JobId");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobId = j.toString();
            }else if (obj!= null && obj instanceof String){
                jobId = (String) obj;
            }
        }
        if (soapObject.hasProperty("JobName"))
        {
            Object obj = soapObject.getProperty("JobName");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobName = j.toString();
            }else if (obj!= null && obj instanceof String){
                jobName = (String) obj;
            }
        }
        if (soapObject.hasProperty("JobQuota"))
        {
            Object obj = soapObject.getProperty("JobQuota");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobQuota = Integer.parseInt(j.toString());
            }else if (obj!= null && obj instanceof Number){
                jobQuota = (Integer) obj;
            }
        }
        if (soapObject.hasProperty("JobQuotaSpecified"))
        {
            Object obj = soapObject.getProperty("JobQuotaSpecified");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                jobQuotaSpecified = Boolean.parseBoolean(j.toString());
            }else if (obj!= null && obj instanceof Boolean){
                jobQuotaSpecified = (Boolean) obj;
            }
        }
    }
    @Override
    public Object getProperty(int arg0) {
        switch(arg0){
            case 0:
                return compensationId;
            case 1:
                return employerId;
            case 2:
                return jobCompensationValue;
            case 3:
                return jobCompensationValueSpecified;
            case 4:
                return jobDescription;
            case 5:
                return jobExperienceLevel;
            case 6:
                return jobId;
            case 7:
                return jobName;
            case 8:
                return jobQuota;
            case 9:
                return jobQuotaSpecified;
        }
        return null;
    }
    
    @Override
    public int getPropertyCount() {
        return 10;
    }
    
    @Override
    public void getPropertyInfo(int index, @SuppressWarnings("rawtypes") Hashtable arg1, PropertyInfo info) {
        switch(index){
            case 0:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "CompensationId";
                break;
            case 1:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "EmployerId";
                break;
            case 2:
                info.type = Double.class;
                info.name = "JobCompensationValue";
                break;
            case 3:
                info.type = PropertyInfo.BOOLEAN_CLASS;
                info.name = "JobCompensationValueSpecified";
                break;
            case 4:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "JobDescription";
                break;
            case 5:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "JobExperienceLevel";
                break;
            case 6:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "JobId";
                break;
            case 7:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "JobName";
                break;
            case 8:
                info.type = PropertyInfo.INTEGER_CLASS;
                info.name = "JobQuota";
                break;
            case 9:
                info.type = PropertyInfo.BOOLEAN_CLASS;
                info.name = "JobQuotaSpecified";
                break;
        }
    }
    

    
    @Override
    public void setProperty(int arg0, Object arg1) {
    }
    
}
