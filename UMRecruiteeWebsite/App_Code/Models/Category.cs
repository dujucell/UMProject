using System;
using System.Collections.Generic;

namespace UMRecruiteeWebsite.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Recruitees = new List<Recruitee>();
        }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public virtual ICollection<Recruitee> Recruitees { get; set; }
    }
}
