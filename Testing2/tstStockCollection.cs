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
        public void addMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock testStock = new clsStock();
            Int32 PrimaryKey = 0;
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            allStock.thisStock = testStock;
            PrimaryKey = allStock.Add();
            testStock.productID = PrimaryKey;
            allStock.thisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.thisStock, testStock);

        }

        [TestMethod]
        public void updateMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock testStock = new clsStock();
            Int32 PrimaryKey = 0;
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            allStock.thisStock = testStock;
            PrimaryKey = allStock.Add();
            testStock.productID = PrimaryKey;
            testStock.productName = "fanta lemon";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 40;
            testStock.lastDelivery = DateTime.Now.Date;
            testStock.inStock = true;
            allStock.thisStock = testStock;
            allStock.Update();
            allStock.thisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.thisStock, testStock);
        }

        [TestMethod]
        public void deleteMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock testStock = new clsStock();
            Int32 PrimaryKey = 0;
            testStock.productID = 1;
            testStock.productName = "Fanta Orange";
            testStock.supplierName = "Fanta";
            testStock.quantityAvailable = 23;
            testStock.inStock = true;
            testStock.lastDelivery = DateTime.Now.Date;
            allStock.thisStock = testStock;
            PrimaryKey = allStock.Add();
            testStock.productID = PrimaryKey;
            allStock.thisStock.Find(PrimaryKey);
            allStock.Delete();
            Boolean found = allStock.thisStock.Find(PrimaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void reportBySupplierName()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStockCollection filteredStock = new clsStockCollection();
            filteredStock.ReportBySupplierName("");
            Assert.AreEqual(allStock.count, filteredStock.count);
        }

        [TestMethod]
        public void reportBySupplierNameNoneFound()
        {
            clsStockCollection filteredStock = new clsStockCollection();
            filteredStock.ReportBySupplierName("xxxxxxxxxxxx");
            Assert.AreEqual(0, filteredStock.count);
        }
        
        [TestMethod]
        public void reportByPostCodeTestDataFound()
        {
            clsStockCollection filteredStock = new clsStockCollection();
            Boolean OK = true;
            filteredStock.ReportBySupplierName("YYYYYY");
            if(filteredStock.count == 2)
            {
                if (filteredStock.stockList[0].productID != 30)
                {
                    OK = false;
                }
                if(filteredStock.stockList[1].productID != 31)
                {
                    OK = false;
                }
                else
                {
                    OK = true;
                }
                Assert.IsTrue(OK);
            }
        }


    }
}




