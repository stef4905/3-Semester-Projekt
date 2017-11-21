using BusinessLogicLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
{

    public class CompanyService : ICompanyService
    {
        private CompanyCtr companyCtr = new CompanyCtr();
        private WorkHoursCtr workHoursCtr = new WorkHoursCtr();
        private JobCategoryCtr jobCategoryCtr = new JobCategoryCtr();
        private JobPostCtr jobPostCtr = new JobPostCtr();

        /// <summary>
        /// Creates an object and executes the Create Method in the CompanyCtr Class
        /// And puts the object into the database!
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
            jobPostCtr.Create(jobPost);
        }

        /// <summary>
        /// Gets all objects and from the GetAll Method in the JobPostCtr Class
        /// And gets all the object from the database.
        /// </summary>
        /// <returns></returns>
        public List<JobCategory> GetAllJobCategories()
        {
            return jobCategoryCtr.GetAll();
        }

        /// <summary>
        /// Gets all objects and from the GetAll Method in the WorkHoursCtr Class
        /// And gets all the object from the database.
        /// </summary>
        /// <returns></returns>
        public List<WorkHours> GetlAllWorkHours()
        {
            return workHoursCtr.GetAll();
        }

        /// <summary>
        /// Get a applier object, from the login method with the given params
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Company Login(string email, string password)
        {
            return companyCtr.Login(email, password);
        }
    }
}

