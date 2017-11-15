using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest.DataAccessLayer
{
    /// <summary>
    /// Summary description for DBJobPostTest
    /// </summary>
    [TestClass]
    public class DBJobPostTest
    {
        [TestMethod]
        public void CreateJobPostDBTest()
        {
            //Arrange
            DbCompany dbCompany = new DbCompany();
            Company company = new Company("imacompany@gmai.om", "hellopassword");
            company.Id = 1;
            WorkHours workHours = new WorkHours();
            workHours.Id = 1;
            JobCategory jobCategory = new JobCategory();
            jobCategory.Id = 1;


            string iDate = "05/05/2018";
            DateTime oDate = Convert.ToDateTime(iDate);
            JobPost jobPost = new JobPost("Test job1", "Et job for dig", DateTime.Now, oDate, "Wc Vasker", workHours, "Her", company, jobCategory);



            //Act
            bool inserted = dbCompany.createJobPost(jobPost);

            //Assert
            Assert.IsTrue(inserted);
        }

        [TestMethod]
        public void FindAllJobPost()
        {
            //Arrange
            Db

            //Act

            //Assert
        }

    }
}
