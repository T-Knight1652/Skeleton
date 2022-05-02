using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign to the property
            //a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to the list 
            //create the item of the test dat 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Comments = "comment 1";
            TestItem.Dispatch = true;
            TestItem.Item = "Item 1";
            TestItem.Price = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            //test tp see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object 
            TestOrder.Comments = "comment 1";
            TestOrder.Dispatch = true;
            TestOrder.Item = "Item 1";
            TestOrder.Price = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the tow values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create soem test data to assign to the property - list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add the item to the list 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Comments = "comment 1";
            TestItem.Dispatch = true;
            TestItem.Item = "Item 1";
            TestItem.Price = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to see taht one of the values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //craete the test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Comments = "comment 1";
            TestItem.Dispatch = true;
            TestItem.Item = "Item 1";
            TestItem.Price = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //set the record to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the teste dat a
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see taht the two valueas are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //craete the test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Comments = "comment 1";
            TestItem.Dispatch = true;
            TestItem.Item = "Item 1";
            TestItem.Price = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data 
            TestItem.Comments = "comment 2";
            TestItem.Dispatch = false;
            TestItem.Item = "Item 2";
            TestItem.Price = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            //set the record based on the new test data 
            AllOrders.ThisOrder = TestItem;
            //update the record 
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test ot see ThisOrder matches the test data 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK() 
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create teh item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store teh primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Comments = "comment 1";
            TestItem.Dispatch = true;
            TestItem.Item = "Item 1";
            TestItem.Price = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record 
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //testt to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByItemMethodOK() 
        {
            //create an instnce of the filterd data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a Item that does not exit
            FilteredOrders.ReportByItem("Item 88");
            //test to see that there are no records
            Assert.AreEqual(0,FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByItemTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilterredOrders = new clsOrderCollection();
            //var to stor ethe outcome 
            Boolean OK = true;
            //apply the item that does not exist 
            FilterredOrders.ReportByItem("Item99");
            //check that the correct number of records are found 
            if (FilterredOrders.Count == 2)
            {
                //chec that the first record is ID 37
                if (FilterredOrders.OrderList[0].OrderID != 36)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see atht there are no records 
            Assert.IsTrue(OK);
        }
        
    }
}
