using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobMeHomePage.Models
{
    public class VMJobCVAndApplication
    {
            public JobMeHomePage.JobCVServiceReference.JobCV JobCV { get; set; }
            public JobMeHomePage.ApplierServiceReference.Applier Applier { get; set; }
            public JobMeHomePage.JobApplicationServiceReference.JobApplication jobApplication { get; set; }
    }
}
