using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobMeHomePage.Models
{
    public class VMJobCVAndApplication
    {
        public JobMeHomePage.ApplierServiceReference.Applier Applier { get; set; }
        public List<JobApplicationServiceReference.JobApplication> jobApplicationList { get; set; }

    }
}
