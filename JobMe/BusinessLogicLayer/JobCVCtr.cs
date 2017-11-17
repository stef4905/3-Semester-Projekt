using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class JobCVCtr : IController<JobCV>
    {
        DBJobCV dbJobCV = new DBJobCV();
        JobExperienceCtr jobExperienceCtr = new JobExperienceCtr();
        ApplierEducationCtr applierEducationCtr = new ApplierEducationCtr();
        JobAppendixCtr jobAppendixCtr = new JobAppendixCtr();

        public void Create(JobCV obj)
        {
            dbJobCV.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobCV Get(int applierId)
        {
            JobCV jobCV = dbJobCV.Get(applierId);
            jobCV.JobExperienceList = jobExperienceCtr.GetAllByJobCVId(jobCV.Id);
            jobCV.ApplierEducationList = applierEducationCtr.GetAllByJobCVId(jobCV.Id);
            jobCV.JobAppendixList = jobAppendixCtr.GetAllByJobCVId(jobCV.Id);
            return jobCV;
        }

        public List<JobCV> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(JobCV obj)
        {
            dbJobCV.Update(obj);

            foreach (var Experience in obj.JobExperienceList)
            {
                jobExperienceCtr.Update(Experience);
            }
            foreach (var Education in obj.ApplierEducationList)
            {
                applierEducationCtr.Update(Education);
            }
            foreach (var Appendix in obj.JobAppendixList)
            {
                jobAppendixCtr.Update(Appendix);
            }
        }
    }
}
