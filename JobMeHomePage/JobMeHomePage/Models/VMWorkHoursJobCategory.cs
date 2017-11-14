using JobMeHomePage.CompanyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobMeHomePage.Models
{
    public class VMWorkHoursJobCategory
    {
        public List<WorkHours> WorkHoursList { get; set; }
        public List<JobCategory> JobCategoryList { get; set; }
    }
}