 using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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


    }
}
