using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLogicLayer;

namespace WCFJobMe
{
   
    public class CompanyService : ICompanyService
    {
        private CompanyCtr companyCtr = new CompanyCtr();

        /// <summary>
        /// Creates an object and executes the Create Method in the CompanyCtr Class
        /// And puts the object into the database.
        /// </summary>
        /// <param name="company"></param>
        public void Create(Company company)
        {
            companyCtr.Create(company);
        }


        /// <summary>
        /// Creates an object and executes the CreateJobPost Method in the CompanyCtr Class
        /// And puts the object into the database.
        /// </summary>
        /// <param name="jobPost"></param>
        public void CreateJobPost(JobPost jobPost)
        {
            companyCtr.CreateJobPost(jobPost);
        }
    }
}
