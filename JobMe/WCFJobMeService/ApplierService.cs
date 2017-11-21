using BusinessLogicLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ApplierService" in both code and config file together.
    public class ApplierService : IApplierService
    {
        private ApplierCtr applierCtr = new ApplierCtr();


        /// <summary>
        /// Creates a new Applier in the database
        /// </summary>
        /// <param name="applier"></param>
        public void Create(Applier applier)
        {
            applierCtr.Create(applier);
        }

        /// <summary>
        /// Returns a list of all Appliers from the database
        /// </summary>
        /// <returns></returns>
        public List<Applier> GetAllAppliers()
        {
            return applierCtr.GetAll();
        }

        /// <summary>
        /// Returns a single Applier object with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Applier GetApplier(int id)
        {
            return applierCtr.Get(id);
        }

        /// <summary>
        ///  Get a company object, from the login method with the given params
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Applier Login(string email, string password)
        {
            return applierCtr.Login(email, password);
        }
    }
}
