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
            JobCV jobCV = new JobCV(1, "Jensens bøfhus", 15, "Bio");
            DBJobCV dbJobCV = new DBJobCV();

            //Act
            bool inserted = dbJobCV.Create(jobCV);

            //Assert
            Assert.IsTrue(inserted);
        }

        [TestMethod]
        public void GetTest()
        {
            //Arrange
            JobCVCtr jobCVCtr = new JobCVCtr();

            //Act
            JobCV jobCv = jobCVCtr.Get(15);

            //Assert
            Assert.IsTrue(jobCv != null);

        }
    }
}
