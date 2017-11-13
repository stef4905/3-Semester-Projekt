using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using Moq;
using System.Data.SqlClient;

namespace DataAccessLayer.Tests
{
    [TestClass()]
    public class DBApplierTest
    {
        

        [TestMethod()]
        public void CreateTest(int id, string Email, string Password, int MaxRadius)
        {
            //Applier actual = new Applier(1, "test@test.dk", "1234", 50);
            //DbApplier dbApplier = new DbApplier();

            //dbApplier.Create(actual);

            ////Assert.AreEqual(actual, expected);
        }
    }
}