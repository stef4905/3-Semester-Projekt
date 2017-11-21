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


        /// <summary>
        /// return a object through the DataAccessLayer, and find a company with the given param
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Company Login(string email, string password)
        {
            return dbCompany.Login(email, password);
        }
    }
}
