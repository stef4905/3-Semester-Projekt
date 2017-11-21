using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLogicLayer;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobCVService" in both code and config file together.
    public class JobCVService : IJobCVService
    {
        JobCVCtr jobCVCtr = new JobCVCtr();

        public void Create(JobCV jobCV, Applier applier)
        {
            jobCVCtr.Create(jobCV, applier);
        }

        public void Delete(int id)
        {
            jobCVCtr.Delete(id);
        }

        public JobCV Get(int id)
        {
            return jobCVCtr.Get(id);
        }

        public List<JobCV> GetAll()
        {
            return jobCVCtr.GetAll();
        }

        public void Update(JobCV obj)
        {
            jobCVCtr.Update(obj); ;
        }
    }
}
