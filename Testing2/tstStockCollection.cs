using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void instanceOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            Assert.IsNotNull(allStock);
        }

        [TestMethod]
        public void stockListOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> testList = new List<clsStock>();
            clsStock testStock = new clsStock();
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            testList.Add(testStock);
            allStock.stockList = testList;
            Assert.AreEqual(allStock.stockList, testList);

        }

        [TestMethod]
        public void countStockOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            Int32 someCount = 0;
            allStock.count = someCount;
            Assert.AreEqual(allStock.count, someCount);
        }

        [TestMethod]
        public void thisStockOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock testStock = new clsStock();
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            allStock.thisStock = testStock;
            Assert.AreEqual(allStock.thisStock, testStock);
        }
        [TestMethod]
        public void listAndCountOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> testList = new List<clsStock>();
            clsStock testStock = new clsStock();
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            testList.Add(testStock);
            allStock.stockList = testList;
            Assert.AreEqual(allStock.count, testList.Count);
        }

        [TestMethod]
        public void twoRecordsPresent()
        {
            clsStockCollection allStock = new clsStockCollection();
            Assert.AreEqual(2, allStock.count);
        }
    }

   

}
