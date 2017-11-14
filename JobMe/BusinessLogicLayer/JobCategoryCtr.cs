using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class JobCategoryCtr : IController<JobCategory>
    {
        DbJobCategory dbJobCategory = new DbJobCategory();
        public void Create(JobCategory obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is a method that calls the GetAll method from the DbAccesLayer
        /// </summary>
        /// <returns></returns>
        public List<JobCategory> GetAll()
        {
            return dbJobCategory.GetAll();
        }

        public void Update(JobCategory obj)
        {
            throw new NotImplementedException();
        }
    }
}
