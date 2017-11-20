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

        /// <summary>
        /// Cunstroctor with the needed parameters
        /// </summary>
        /// <param name="jobCV"></param>
        /// <param name="applier"></param>
        public VMJobCVAndApplication(JobMeHomePage.JobCVServiceReference.JobCV jobCV, JobMeHomePage.ApplierServiceReference.Applier applier)
        {
            this.JobCV = jobCV;
            this.Applier = applier;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public VMJobCVAndApplication()
        {
        }
    }
}