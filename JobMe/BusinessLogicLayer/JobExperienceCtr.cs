using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class JobExperienceCtr : IController<JobExperience>
    {
        DBJobExperience dbJobExperience = new DBJobExperience();

        public void Create(JobExperience obj)
        {
            dbJobExperience.Create(obj);
        }

        public void Delete(int id)
        {
            dbJobExperience.Delete(id);
        }

        public JobExperience Get(int id)
        {
            return dbJobExperience.Get(id);
        }

        public List<JobExperience> GetAllByJobCVId(int id)
        {
            return dbJobExperience.GetAllByJobCVId(id);
        }

        public List<JobExperience> GetAll()
        {
            return dbJobExperience.GetAll();
        }

        public void Update(JobExperience obj)
        {
            dbJobExperience.Update(obj);
        }
    }
}
