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
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Dispatch = true;
            TestItem.Comments = "Some commnets ";
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 2.00;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
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
            TestOrder.Dispatch = true;
            TestOrder.Comments = "Some commnets ";
            TestOrder.Item = "drink 1";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderID = 1;
            TestOrder.Price = 2.00;
            //assign the data to the property 
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the calss we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to thelist 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Comments = "some comments ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 1.00;
            //add the item to the test list 
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //crate the item of the test dat 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            var PrimaryKey = 0;
            //set its properties 
            TestItem.Comments = "some comments ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 1.00;
            //sest ThisORder to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to tsee that the two values are the sam e
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Comments = "some comments ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 1.00;
            //set thisCustomer to the test data
            AllOrders.ThisOrder = TestItem;
            //a the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.Comments = "other comments ";
            TestItem.Dispatch = false;
            TestItem.Item = "drink 2";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 2;
            TestItem.Price = 2.00;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
            AllOrders.Delete();
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Comments = "some comments ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 1.00;
            //set ThisORdr to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary ey of the test data 
            TestItem.OrderID = PrimaryKey;
            //delete the record 
            AllOrders.Delete();
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByItemsMethodOk()
        {
            //create an instacn eof the clas containing the unfitelred results 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instace of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string - should return all the records
            FilteredOrders.ReportByItems("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);

        }
    }
}
