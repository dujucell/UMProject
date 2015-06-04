using System;
using System.Collections.Generic;
using UMWebsite.Models;
using System.Runtime.Serialization;

namespace UMWebsite.DomainDTO
{
    [DataContract]
    public class CategoryDto
    {
        [DataMember]
        public string CategoryId { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        public static CategoryDto createCategoryDTO(Category obj)
        {
            CategoryDto cat = new CategoryDto();
            cat.CategoryId = obj.CategoryId;
            cat.CategoryName = obj.CategoryName;
            return cat;
        }

        public static CategoryDto createCategoryDTO(String CategoryId, String CategoryName)
        {
            CategoryDto cat = new CategoryDto();
            cat.CategoryId = CategoryId;
            cat.CategoryName = CategoryName;
            return cat;
        }
    }
}