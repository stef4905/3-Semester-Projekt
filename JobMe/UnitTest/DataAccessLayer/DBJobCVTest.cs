using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest.DataAccessLayer
{
    [TestClass]
    public class DBJobCVTest
    {
        [TestMethod]
        public void CreateJobCVInDB()
        {
            //Arrange
            JobCV jobCV = new JobCV(1, "Jensens bøfhus", 15);
            DBJobCV dbJobCV = new DBJobCV();

            //Act
            bool inserted = dbJobCV.Create(jobCV);

            //Assert
            Assert.IsTrue(inserted);
        }
    }
}
