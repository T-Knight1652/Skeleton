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

    }
}
