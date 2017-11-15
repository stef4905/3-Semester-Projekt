using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class JobPostCtr : IController<JobPost>
    {
        private DbJobPost dbJobPost = new DbJobPost();

        /// <summary>
        /// Sends an Object throug the DataAccessLayer, and executes CreateJobPost Method
        /// </summary>
        /// <param name="obj"> Object for Jobpost </param>

        public void Create(JobPost obj)
        {
            dbJobPost.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobPost Get(int id)
        {
            return dbJobPost.Get(id);
        }

        public List<JobPost> GetAll()
        {
            return dbJobPost.GetAll();
        }

        public void Update(JobPost obj)
        {
            throw new NotImplementedException();
        }
    }
}
