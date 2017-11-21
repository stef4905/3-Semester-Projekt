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
    public class JobCVCtr // Does not implement the IController, but when controller is changed this class needs to be refactored
    {
        DBJobCV dbJobCV = new DBJobCV();
        JobExperienceCtr jobExperienceCtr = new JobExperienceCtr();
        ApplierEducationCtr applierEducationCtr = new ApplierEducationCtr();
        JobAppendixCtr jobAppendixCtr = new JobAppendixCtr();
        ApplierCtr applierCtr = new ApplierCtr();
        
        public void Create(JobCV jobCV, Applier applier)
        {
            applier.jobCV = dbJobCV.Create(jobCV);
            applierCtr.Update(applier);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobCV Get(int id)
        {
            JobCV jobCV = dbJobCV.Get(id);
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
