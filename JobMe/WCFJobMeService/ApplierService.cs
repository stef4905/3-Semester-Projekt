﻿using BusinessLogicLayer;
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
        private JobCVCtr jobCVCtr = new JobCVCtr();

        /// <summary>
        /// Creates a new Applier in the database
        /// </summary>
        /// <param name="applier"></param>
        public void CreateApplier(Applier applier)
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
        public Applier LoginApplier(string email, string password)
        {
            return applierCtr.Login(email, password);
        }

        public void UpdateApplier(Applier applier)
        {
            applierCtr.Update(applier);
        }

        public void CreateJobCV(JobCV jobCV, Applier applier)
        {
            jobCVCtr.Create(jobCV, applier);
        }

        public void DeleteJobCV(int id)
        {
            jobCVCtr.Delete(id);
        }

        public JobCV GetJobCV(int id)
        {
            return jobCVCtr.Get(id);
        }

        public List<JobCV> GetAllJobCV()
        {
            return jobCVCtr.GetAll();
        }

        public void UpdateJobCV(JobCV obj)
        {
            jobCVCtr.Update(obj); ;
        }
    }
}
