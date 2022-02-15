using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the calss we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void OverEighteenPropertOK()
        {
            //create an instance of the class.
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            ACustomer.OverEighteen = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.OverEighteen, TestData);
        }
        [TestMethod]
        public void CreationDatePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CreationDate = TestData;
            Assert.AreEqual(ACustomer.CreationDate, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "JoeBloggs@gmail.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void FullnamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Joe Bloggs";
            ACustomer.Fullname = TestData;
            Assert.AreEqual(ACustomer.Fullname, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Password123";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void CustomerID()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
    }
}
