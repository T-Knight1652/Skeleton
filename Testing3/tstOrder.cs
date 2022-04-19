using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {

        //good test data 
        //some test data to pass to the method 
        string OrderDate = DateTime.Now.Date.ToString();
        string Comments = "some comments ";
        string Price = "12.00";


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
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //create tsome teast data to assign to the property
            double testData = 54.2;
            //assign the testdata to the property
            order.Price = testData;
            //test to see that the two values are the same
            Assert.AreEqual(order.Price, testData);
        }

        [TestMethod]
        public void DispatchOK()
        {
            //creates an instance of the class
            clsOrder order = new clsOrder();
            //creates some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            order.Dispatch = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(order.Dispatch, TestData);
        }



        [TestMethod]
        public void CommentsOK()
        {
            //creates an instance of the class
            clsOrder order = new clsOrder();
            //creates some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            order.Comments = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(order.Comments, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //booolean variable to store teh result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method 
            Found = order.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data if the data is okay assuming it is 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method
            Found = order.Find(orderID);
            //check the orderID
            if (order.OrderID != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderDateFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data if the data is okay assuming it is 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method
            Found = order.Find(orderID);
            //check the OrderDate
            if (order.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DispatchFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data if the data is okay assuming it is 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method
            Found = order.Find(orderID);
            //check the Dispatch
            if (order.Dispatch != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CommentsFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data if the data is okay assuming it is 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method
            Found = order.Find(orderID);
            //check the Dispatch
            if (order.Comments != "some comments")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void PriceFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data if the data is okay assuming it is 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method
            Found = order.Find(orderID);
            //check the Dispatch
            if (order.Price != 21.10)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = order.Valid(OrderDate, Comments, Price);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

       

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDateAdded = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(OrderDate, Comments, Price, OrderDateAdded);
            //test to see that the restult is correct 
            Assert.AreNotEqual(Error, "");

        }
    }
}
       


    

