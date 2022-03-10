﻿using ClassLibrary;
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void testStockQuantityAvailableFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            if (aStock.quantityAvailable != 23)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void testProductIDFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            if (aStock.productID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testProductNameFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            if (aStock.productName != "Fanta Orange")
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void testSupplierNameFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            if (aStock.supplierName != "Fanta")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void testLastDeliveryFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 productID = 1;
            Found = aStock.Find(productID);
            if (aStock.lastDelivery != Convert.ToDateTime("06 / 03 / 2022")) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void testInStockOK()
        {
            clsStock aStock = new clsStock();
            Boolean found = false;
            Boolean OK = true;
            Int32 productID = 1;
            found = aStock.Find(productID);
            if (aStock.inStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
