using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest
{
    /// <summary>
    /// Summary description for DBJopPostTest
    /// </summary>
    [TestClass]
    public class DBJopPostTest
    {
        [TestMethod]
        public void CreateJobPostDBTest()
        {
            //Arrange
            DbJobPost dbJobPost = new DbJobPost();
            Company company = new Company("imacompany@gmai.om", "hellopassword");
            company.Id = 1;
            WorkHours workHours = new WorkHours();
            workHours.Id = 1;
            JobCategory jobCategory = new JobCategory();
            jobCategory.Id = 1;


            string iDate = "05/05/2018";
            DateTime oDate = Convert.ToDateTime(iDate);
            JobPost jobPost = new JobPost(1, "Test job1", "Et job for dig", DateTime.Now, oDate, "Wc Vasker", workHours, "Her", company, jobCategory);



            //Act
            bool inserted = dbJobPost.Create(jobPost);

            //Assert
            Assert.IsTrue(inserted);
        }

        [TestMethod]
        public void FindAllJobPost()
        {
            //Arrange
            DbJobPost dbJobPost = new DbJobPost();

            //Act
            List<JobPost> jobPostList = dbJobPost.GetAll();

            //Assert
            Assert.IsTrue(jobPostList.Count > 1);
        }

        /// <summary>
        /// Test the Get() method on jobPost in DataAccessLayer.
        /// Testing by validating that the method returns a object (Get(1)) that is not equal to null.
        /// </summary>
        [TestMethod]
        public void GetJobById()
        {
            //Arrange
            DbJobPost dbJobPost = new DbJobPost();

            //Act
            JobPost jobPost = dbJobPost.Get(1);

            //Assert
            Assert.IsTrue(jobPost != null);
        }
    }
}
