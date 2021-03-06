using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3

{

    [TestClass]

    public class tstOrder

    {
        //some test data to pass to the method  

        string OrderDate = DateTime.Now.Date.ToString();
        string Comments = "some comments ";
        string Price = "12.00";
        string Item = "drink 1";

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
            //create an instance of the class we want to create 
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            anOrder.OrderID = TestData;
            //test to see that the two values are the same 
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
            Assert.AreEqual(order.OrderDate, TestData);
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
            string TestData = "some comments";
            //assign the data to the property 
            order.Comments = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(order.Comments, TestData);
        }

        [TestMethod]
        public void ItemOK()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //create some test data to assign to the property 
            string TestData = "drink 1";
            //assign the data to the property 
            order.Item = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(order.Item, TestData);
        }

        [TestMethod]

        public void FindMethodOK()

        {
            //create an instance of the class 
            clsOrder ACustomer = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 OrderID = 2;
            //invoke the method 
            Found = ACustomer.Find(OrderID);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
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
        public void TestOrderDateFound()
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
        public void TestDispatchFound()
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
        public void TestCommentsFound()
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
        public void TestPriceFound()
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
        public void TestItemFound()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 orderID = 21;
            //invoke the method 
            Found = order.Find(orderID);
            //check the property 
            if (order.Item != "drink 1")
            {
                OK = false;
            }
            //test to see that the result is correct 
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
            Error = order.Valid(OrderDate, Comments, Price, Item);
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
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(OrderDate, Comments, Price, Item);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvlidData()
        {
            clsOrder order = new clsOrder();
            String Error = "";
            string OrderDate = "this is not a date";
            string Comments = "some comments";
            string Price = "455.88";
            string Item = "drink 1";
            Error = order.Valid(OrderDate, Comments, Price, Item);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMinLessOne()
        {
            //create an instance of the class  we want to create  
            clsOrder order = new clsOrder();
            //string variable to store any error message  
            String Error = "";
            //create some test data to pass to the method  
        //    string Commnets = ""; //this should trigger an error  
            //invoke the method 
            Error = order.Valid(OrderDate, Comments, Price, Item);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMin()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "a";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMinPlusOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "aa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMaxLessOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMax()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMid()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentsMaxPlusOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Comments = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CommentsExtremeMax()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method
            string Comments = "";
            Comments = Comments.PadRight(500, 'a'); //this should fail 
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ItemMinLessOne()
        {
            //create an instance of the class  we want to create  
            clsOrder order = new clsOrder();
            //string variable to store any error message  
            String Error = "";
            //create some test data to pass to the method  
            string Item = ""; //this should trigger an error  
            //invoke the method 
            Error = order.Valid(OrderDate, Comments, Price, Item);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemMin()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "a";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemMinPlusOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "aa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemMaxLessOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemMax()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemMid()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemMaxPlusOne()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string Item = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemExtremeMax()
        {
            //create an instance of the class 
            clsOrder order = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method
            string Item = "";
            Comments = Comments.PadRight(500, 'a'); //this should fail 
            //invoke the method 
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Price = "-10000000.00";
            //invoke the method
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Price = "-1.00";
            //invoke the method
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "0.00";
            //invoke the method
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "1.00";
            //invoke the method
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Price = "fred";
            //invoke the method
            Error = order.Valid(Comments, Price, Item, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}











