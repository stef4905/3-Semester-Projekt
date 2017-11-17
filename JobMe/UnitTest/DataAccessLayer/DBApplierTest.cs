using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest.DataAccessLayer
{
    [TestClass]
    public class DBApplierTest
    {
        [TestMethod]
        public void ApplierCreateDBTest()
        {
            //Arrange
            DbApplier dbApplier = new DbApplier();
            Applier applier = new Applier("Sofie", "123", 20);

            //Act
            bool inserted = dbApplier.Create(applier);

            //Assert
            Assert.IsTrue(inserted);
        }

        [TestMethod]

        public void ApplierGetById()
        {   
            //Arrange
            DbApplier dbApplier = new DbApplier();
            Applier applier = new Applier();

            //Act
            applier = dbApplier.Get(2);

            //Assert
            Assert.AreEqual(applier.Id, 2);
        }


        [TestMethod]

        public void ApplierLogintest()
        {
            //Arrange
            DbApplier dbApplier = new DbApplier();
            Applier applier = new Applier();

            //Act
            applier = dbApplier.Login("stampe@gmail.com", "123456");

            //Assert
            Assert.AreEqual(applier.Email, "stampe@gmail.com");


        }
    }
}
