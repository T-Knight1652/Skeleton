using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data 
        private string Comments = "Some comments";
        [TestMethod]
        public void InstanceOk()
        {
                //create an instance of the class we want to create
                clsOrder order = new clsOrder();
                //test to see that it exists
                Assert.IsNotNull(order);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder anOrder = new clsOrder();
            int TestData = 1;
            anOrder.OrderID = TestData;
            Assert.AreEqual(anOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //Create some test data
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            order.OrderDate = TestData;
            //test to see if the two values ar the same
            Assert.AreEqual(order.OrderID, TestData);
        }

        [TestMethod]
        public void CommentsOk()
        {

            //create an instance of the class we want to use
            clsOrder order = new clsOrder();
            string TestData = Comments;
            //if comments exists in the order write a value to it 
            order.Comments = TestData;
            //test to see that it exists
            Assert.AreEqual(order.Comments, TestData);


        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //create tsome teast data to assign to the property
            decimal testData = 54;
            //assign the testdata to the property
            order.Price = testData;
            //test to see that the two values are the same
            Assert.AreEqual(order.Price, testData);
        }
        [TestMethod]
        public void DispatchOK()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //Create some test data
            Boolean TestData = false;
            //Assign the data to the property
            class.Dispatch = TestData;
            //test to see if the two values ar the same
            Assert.AreEqual(order.Dispatch, TestData);
        }
    }
}
