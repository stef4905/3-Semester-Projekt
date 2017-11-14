using System;
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

        /// <summary>
        /// Creates a new JobCV in the database
        /// </summary>
        /// <param name="obj"></param>
        public void Create(JobCV obj)
        {
            dbJobCV.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobCV Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobCV> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(JobCV obj)
        {
            throw new NotImplementedException();
        }
    }
}
