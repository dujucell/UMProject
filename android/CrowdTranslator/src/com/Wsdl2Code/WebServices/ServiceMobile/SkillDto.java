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
import java.util.Hashtable;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;

public class SkillDto implements KvmSerializable {
    
    public String skillDescription;
    public String skillId;
    public String skillName;
    
    public SkillDto(){}
    
    public SkillDto(SoapObject soapObject)
    {
        if (soapObject == null)
            return;
        if (soapObject.hasProperty("SkillDescription"))
        {
            Object obj = soapObject.getProperty("SkillDescription");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                skillDescription = j.toString();
            }else if (obj!= null && obj instanceof String){
                skillDescription = (String) obj;
            }
        }
        if (soapObject.hasProperty("SkillId"))
        {
            Object obj = soapObject.getProperty("SkillId");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                skillId = j.toString();
            }else if (obj!= null && obj instanceof String){
                skillId = (String) obj;
            }
        }
        if (soapObject.hasProperty("SkillName"))
        {
            Object obj = soapObject.getProperty("SkillName");
            if (obj != null && obj.getClass().equals(SoapPrimitive.class)){
                SoapPrimitive j =(SoapPrimitive) obj;
                skillName = j.toString();
            }else if (obj!= null && obj instanceof String){
                skillName = (String) obj;
            }
        }
    }
    @Override
    public Object getProperty(int arg0) {
        switch(arg0){
            case 0:
                return skillDescription;
            case 1:
                return skillId;
            case 2:
                return skillName;
        }
        return null;
    }
    
    @Override
    public int getPropertyCount() {
        return 3;
    }
    
    @Override
    public void getPropertyInfo(int index, @SuppressWarnings("rawtypes") Hashtable arg1, PropertyInfo info) {
        switch(index){
            case 0:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "SkillDescription";
                break;
            case 1:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "SkillId";
                break;
            case 2:
                info.type = PropertyInfo.STRING_CLASS;
                info.name = "SkillName";
                break;
        }
    }
    

    
    @Override
    public void setProperty(int arg0, Object arg1) {
    }
    
}
