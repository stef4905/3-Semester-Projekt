using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogicLayer;
using ModelLayer;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobApplicationService" in both code and config file together.
    public class JobApplicationService : IJobApplicationService
    {
        JobApplicationCtr jobAppCtr = new JobApplicationCtr();

        /// <summary>
        /// Create a JobApplication
        /// </summary>
        /// <param name="jobApplication"></param>
        public void Create(JobApplication jobApplication)
        {
            jobAppCtr.Create(jobApplication);
        }

        /// <summary>
        /// Return a Job application by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JobApplication Get(int id)
        {
            return jobAppCtr.Get(id);
        }
        /// <summary>
        /// Gets an object and executes the "GetAllByApplierId" in the JobApplicationCtr Class
        /// 
        /// </summary>
        /// <param name="applierId"></param>
        /// <returns></returns>
        public List<JobApplication> GetAllByApplierId(int applierId)
        {
            return jobAppCtr.GetAllByApplierId(applierId);
        }
    }
}
