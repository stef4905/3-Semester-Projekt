using DataAccessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ApplierCtr : IController<Applier>
    {
        //Connection to database
        private DbApplier dbApplier = new DbApplier();
        JobCVCtr jobCVCtr = new JobCVCtr();

        public void Create(Applier obj)
        {
            dbApplier.Create(obj);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the whole applier and Jobcategory list for the specific applier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Applier Get(int id)
        {
            Applier applier = dbApplier.Get(id);
            
        applier.jobCV = jobCVCtr.Get(applier.jobCV.Id);
            return applier;
        }

        public List<Applier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Applier obj)
        {
            dbApplier.Update(obj);
        }


        /// <summary>
        /// returns an Appiler with the given param
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Applier Login(string email, string password)
        {
            return dbApplier.Login(email, password);
        }
    }
}
