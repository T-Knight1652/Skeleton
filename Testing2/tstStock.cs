using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            clsStock aStock = new clsStock();
            string testString = "TestString";
            aStock.productName = testString;
            Assert.AreEqual(aStock.productName, testString);
        }

        [TestMethod]
        public void SupplierNameOK()
        {
            clsStock aStock = new clsStock();
            string testString = "testName";
            aStock.supplierName = testString;
            Assert.AreEqual(aStock.supplierName, testString);
        }

        [TestMethod]
        public void inStockOK()
        {
            clsStock aStock = new clsStock();
            Boolean testBool = true;
            aStock.inStock = testBool;
            Assert.AreEqual(aStock.inStock, testBool);
        }

        [TestMethod]
        public void QuantityAvailableOK()
        {
            clsStock aStock = new clsStock();
            Int32 testInt = 13;
            aStock.quantityAvailable = testInt;
            Assert.AreEqual(aStock.quantityAvailable, testInt);
        }

        [TestMethod]
        public void LastDeliveryOK()
        {
            clsStock aStock = new clsStock();
            DateTime testDate = DateTime.Now.Date;
            aStock.lastDelivery = testDate;
            Assert.AreEqual(aStock.lastDelivery, testDate);
        }
        [TestMethod]
        public void ProductIdOK()
        {


            clsStock aStock = new clsStock();
            int testInt = 12;
            aStock.productID = testInt;
            Assert.AreEqual(aStock.productID, testInt);
        }
    } 
}
