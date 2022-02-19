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

    }
}
