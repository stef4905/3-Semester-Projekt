using JobMeHomePage.JobPostServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobMeHomePage.Models
{
    public class VMJobPostWorkHoursJobCategory
    {

        public List<JobPost> JobPostList { get; set; }
        public List<WorkHours> WorkHoursList { get; set; }
        public List<JobCategory> JobCategoryList { get; set; }
    }
}