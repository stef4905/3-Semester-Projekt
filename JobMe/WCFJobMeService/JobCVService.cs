using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLogicLayer;

namespace WCFJobMeService
{
    public class JobCVService : IJobCVService
    {
        JobCVCtr jobCVCtr = new JobCVCtr();

        public void Create(JobCV jobCV)
        {
            jobCVCtr.Create(jobCV);
        }

        public void Delete(int id)
        {
            jobCVCtr.Delete(id);
        }

        public JobCV Get(int applierId)
        {
            return jobCVCtr.Get(applierId);
        }

        public List<JobCV> GetAll()
        {
            return jobCVCtr.GetAll();
        }

        public void Update(JobCV obj)
        {
            jobCVCtr.Update(obj);
        }
    }
}
