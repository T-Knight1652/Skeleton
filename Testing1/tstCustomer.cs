using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string Password = "Password12345";
        string Fullname = "William Miles";
        string Email = "WilliamMiles@gmail.com";
        string CreationDate = DateTime.Now.Date.ToString();


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
        public void CustomerIDOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCreationDateFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.CreationDate != Convert.ToDateTime("01/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOverEighteenFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.OverEighteen != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Email != "John.Smith@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullnameFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Fullname != "John Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the CustomerID
            if (ACustomer.Password != "Password123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            // invoke method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Password = "";//should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "a";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "aa";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaaaaaa";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(500, 'a');
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreationDateExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to the date 100 years ago.
            TestDate = TestDate.AddYears(-100);
            //convert date variable to string variable
            string CreationDate = TestDate.ToString();
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreationDateMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CreationDate = TestDate.ToString();
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreationDateMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string CreationDate = TestDate.ToString();
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CreationDateMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CreationDate = TestDate.ToString();
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreationDateExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string CreationDate = TestDate.ToString();
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CreationDateInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //set the Creation date to a non date value
            string CreationDate = "this is not a date";
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "";//should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "a";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "aa";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullnameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullnameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Fullname = "";
            Fullname = Fullname.PadRight(500, 'a');//should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";//should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "e";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "ee";
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
