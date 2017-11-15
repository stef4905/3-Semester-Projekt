using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using ModelLayer;

namespace UnitTest.DataAccessLayer
{
    [TestClass]
    public class DBCompanyTest
    {
        [TestMethod]
        public void CompanyCreateDBTest()
        {
            //Arrange
            DbCompany dbCompany = new DbCompany();
            Company company = new Company("imacompany@gmai.om", "hellopassword");

            //Act
            bool inserted = dbCompany.Create(company);

            //Assert
            Assert.IsTrue(inserted);
        }

       

    }
}
