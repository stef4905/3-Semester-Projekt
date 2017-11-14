using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CompanyCtr : IController<Company>
    {

        private DbCompany dbCompany = new DbCompany();

        /// <summary>
        /// Sends an object through the DataAccessLayer, and executes Create Method
        /// </summary>
        /// <param name="obj"></param>
        public void Create(Company obj)
        {
            dbCompany.Create(obj);
        }


        /// <summary>
        /// Sends an Object throug the DataAccessLayer, and executes CreateJobPost Method
        /// </summary>
        /// <param name="obj"> Object for Jobpost </param>
        public void CreateJobPost(JobPost obj)
        {
            dbCompany.createJobPost(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
