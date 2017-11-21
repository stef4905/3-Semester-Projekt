using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;
using BusinessLogicLayer;

namespace UnitTest.DataAccessLayer
{
    [TestClass]
    public class DBJobCVTest
    {
        [TestMethod]
        public void CreateJobCVInDB()
        {
            //Arrange
            JobCV jobCV = new JobCV(1, "Jensens bøfhus", "Bio");
            DBJobCV dbJobCV = new DBJobCV();

            //Act
            JobCV jobCVReturned = dbJobCV.Create(jobCV);

            //Assert
            Assert.IsNotNull(jobCVReturned);
        }

        [TestMethod]
        public void GetJobCVTest()
        {
            //Arrange
            JobCVCtr jobCVCtr = new JobCVCtr();

            //Act
            JobCV jobCv = jobCVCtr.Get(1);

            //Assert
            Assert.IsTrue(jobCv != null);

        }
    }
}
