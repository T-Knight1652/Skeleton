using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {


        string productName = "drink";
        string supplierName = "DrinkSupplier";
        string quantityAvailable = "2";
        string lastDelivery = DateTime.Now.Date.ToString();


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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock aStock = new clsStock();
            string error = "";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void productNameMinMinus1()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string productName = "";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual(error, "");


        }

        [TestMethod]
        public void productNameMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string productName = "a";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void productNameMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string productName = "aa";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);

        }
        [TestMethod]
        public void productNameMid()
        {
            clsStock aStock = new clsStock();
            string error = "";
            productName = (string)productName.PadRight(15, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void productNameMaxMinusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            productName = (string)productName.PadRight(29, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void productNameMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            productName = (string)productName.PadRight(30, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            productName = (string)productName.PadRight(31, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void productNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            productName = (string)productName.PadRight(1000, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void supplierNameMinMinus1()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string supplierName = "";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual(error, "");


        }

        [TestMethod]
        public void supplierNameMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string supplierName = "a";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void supplierNameMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = "aa";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);

        }

        [TestMethod]
        public void supplierNameMid()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = (string)supplierName.PadRight(15, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void supplierNameMaxMinusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = (string)supplierName.PadRight(29, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void supplierNameMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = (string)supplierName.PadRight(30, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void supplierNameMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = (string)supplierName.PadRight(31, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void supplierNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            supplierName = (string)supplierName.PadRight(1000, 'a');
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void lastDeliveryExtremeMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-1000);
            string lastDelivery = testDate.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void lastDeliveryMinMinusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string lastDelivery = testDate.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void lastDeliveryMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            DateTime testDate = DateTime.Now.Date;
            string lastDelivery = testDate.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void lastDeliveryMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string lastDelivery = testDate.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void lastDeliveryExtremeMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(1000);
            string lastDelivery = testDate.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void lastDeliveryWrongDataType()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string lastDelivery = "TestString";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }
        [TestMethod]
        public void quantityAvailableExtremeMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = -1000;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void QuantityAvailableMinMinusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = -1;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);

        }

        [TestMethod]
        public void quantityAvailableMin()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 0;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void quantityAvailableMinPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 1;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void quantityAvailableMid()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 5000;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void quantityAvailableMaxMinusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 9999;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        
            

        }

        [TestMethod]
        public void quantityAvailableMax()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 10000;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void quantityAvailableMaxPlusOne()
        {
            clsStock aStock = new clsStock();
            string error = "";
            int testInt = 10001;
            string quantityAvailable = testInt.ToString();
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void quantityAvailableWrongDataType()
        {
            clsStock aStock = new clsStock();
            string error = "";
            string quantityAvailable = "aaa";
            error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
            Assert.AreNotEqual("", error);
        }
            
    }
}

