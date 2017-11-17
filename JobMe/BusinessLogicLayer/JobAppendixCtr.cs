using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class JobAppendixCtr : IController<JobAppendix>
    {
        DBJobAppendix dbJobAppendix = new DBJobAppendix();

        public void Create(JobAppendix obj)
        {
            dbJobAppendix.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobAppendix Get(int id)
        {
            return dbJobAppendix.Get(id);
        }

        public List<JobAppendix> GetAllByJobCVId(int id)
        {
            return dbJobAppendix.GetAllByJobCVId(id); 
        }

        public List<JobAppendix> GetAll()
        {
            return dbJobAppendix.GetAll();
        }

        public void Update(JobAppendix obj)
        {
            dbJobAppendix.Update(obj);
        }
    }
}
