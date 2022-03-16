 using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        //good test data
        //create some test data to pass to the method
        string BrandName = "some brand";
        string Quantity = "50";
        string Total = "69.99";
        string NextDelivery = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(aSupplier);
        }
        [TestMethod]
        public void BrandNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create tsome teast data to assign to the property
            String testData = "Generic Brand Name";
            //assign the testdata to the property
            aSupplier.BrandName = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.BrandName, testData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create tsome teast data to assign to the property
            int testData = 35;
            //assign the testdata to the property
            aSupplier.Quantity = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.Quantity, testData);
        }

        [TestMethod]
        public void TotalOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create tsome teast data to assign to the property
            Double testData = 54.50;
            //assign the testdata to the property
            aSupplier.Total = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.Total, testData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create tsome teast data to assign to the property
            Boolean testData = true;
            //assign the testdata to the property
            aSupplier.Active = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.Active, testData);
        }

        [TestMethod]
        public void NextDeliveryOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create tsome teast data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the testdata to the property
            aSupplier.NextDelivery = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.NextDelivery, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.ProductID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestBrandNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.BrandName != "Lucozade")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.Quantity != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.Total != 65.0)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestNextDeliveryFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = ASupplier.Find(ProductID);
            //check the property
            if (ASupplier.NextDelivery != Convert.ToDateTime("14/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //BrandName validation testing

        [TestMethod]
        public void BrandNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String BrandName = "";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String BrandName = "c";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should pass
            String BrandName = "ce";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should pass
            String BrandName = "cel";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should pass
            String BrandName = "ofYTDeMNAUamlclKXXNr8V98m0RfYeSZPhwLHHrWaro8cBl8f";  //49
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should pass
            String BrandName = "ofYTDeMNAUamlclKXXNr8V98m0RfYeSZPhwLHHrWaro8cBl8fg"; //50
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should fail
            String BrandName = "ofYTDeMNAUamlclKXXNr8V98m0RfYeSZPhwLHHrWaro8cBl8fgl"; //51
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should pass
            String BrandName = "W0rrofS4TCOWgZuQYyul3qnV8"; //25
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            string Error = "";
            //this should fail
            String BrandName = "17ftWvci8Mt1ZZiNM9Hzck8NYLgunbQS8uganAa4lkpny" +
                               "SZ0fwBm0kSAA92rhrcMzQZT6VeF1MOvNrFIPT7I58YDSM" +
                               "jHor8PrshOPw9HnV56Q61gtPUwJ0JBCxZuOjmCQ0LDN0Z" +
                               "pbhmpqNwhWrLTvle5lS3nIe1bMi8Lze709DefopFUpuLE" +
                               "u0Y61JpkwmVcLwyPB3PxFIkoJmAG9s6Kdm5yMFVFcbv5O" +
                               "YGdfLPMGHvkrKyXgFEZw1iTa7CoF7rX7o6rC2drSuzs2M" +
                               "bvm03VP0P6CNDOx6xbB87aH10hVPMbZ0I0mbVU23pUOQ7" +
                               "pi9w5t1oekJXW4sASeoq2yONlZSwBYbl9oPv3MLQdiorz" +
                               "5nCOC03DuRwKCrJ7px1QyOVMlPhoTnUgOUsSbndSqZSaC" +
                               "aOHO7bVZBaRmJF2lHHE4wrehgdzQdZVym8G9qzVkS7jrM" +
                               "1lDLL4tEktDZTL7aXI7Bun4rGKIdiSvEXrgU5EYzc1vaQ" +
                               "zo2bv"; //500
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Quantity validation testing

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Quantity = "-100";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Quantity = "1";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Quantity = "2";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Quantity = "2";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Quantity = "2147483646";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Quantity = "2147483647";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Quantity = "2147483648";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Quantity = "9999999999";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Quantity = "1073741824";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Quantity = "fred";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Total validation testing

        [TestMethod]
        public void TotalExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Total = "-10000000";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Total = "-0.01";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Total = "0.00";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Total = "0.01";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Total = "fred";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //NextDelivery validation testing

        [TestMethod]
        public void NextDeliveryExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            String NextDelivery = TestDate.ToString();
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NextDeliveryMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            String NextDelivery = TestDate.ToString();
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NextDeliveryMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            String NextDelivery = TestDate.ToString();
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NextDeliveryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            String NextDelivery = TestDate.ToString();
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NextDeliveryInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String NextDelivery = "fred";
            //invoke the method
            Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }








    }
}
