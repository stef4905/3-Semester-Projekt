using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest.DataAccessLayer
{
    [TestClass]
    public class DBJobApplicationTest
    {
        [TestMethod]
        public void CreateJobApplicationInDB()
        {
            //Arrange
            DbJobApplication dbJobApplication = new DbJobApplication();
            JobApplication jobApplication = new JobApplication(1, "Title", "Description", 15);

            //Act
            bool inserted = dbJobApplication.Create(jobApplication);

            //Assert
            Assert.IsTrue(inserted);
        }
    }
}
