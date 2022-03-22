using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.OverEighteen = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "Bob@gmail.com";
            TestItem.Fullname = "Bob Bailey";
            TestItem.Password = "AppleADay";
            TestItem.CreationDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.OverEighteen = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.Email = "Bob@gmail.com";
            TestCustomer.Fullname = "Bob Bailey";
            TestCustomer.Password = "AppleADay";
            TestCustomer.CreationDate = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to tassign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.OverEighteen = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "Bob@gmail.com";
            TestItem.Fullname = "Bob Bailey";
            TestItem.Password = "AppleADay";
            TestItem.CreationDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OverEighteen = true;
            TestItem.CustomerID = 1;
            TestItem.CreationDate = DateTime.Now.Date;
            TestItem.Fullname = "Katie Paxton";
            TestItem.Password = "Moo123";
            TestItem.Email = "Katie@gmail.com";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
            AllCustomers.Delete();
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OverEighteen = true;
            TestItem.CreationDate = DateTime.Now.Date;
            TestItem.Fullname = "Umar Siksek";
            TestItem.Password = "Runescaper123";
            TestItem.Email = "UmaSik@gmail.com";
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.OverEighteen = false;
            TestItem.CreationDate = DateTime.Now.Date;
            TestItem.Fullname = "Alfie Knight";
            TestItem.Password = "LazyFatCat666";
            TestItem.Email = "Cat2@talktalk.net";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
            AllCustomers.Delete();
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OverEighteen = true;
            TestItem.CustomerID = 1;
            TestItem.CreationDate = DateTime.Now.Date;
            TestItem.Fullname = "Katie Paxton";
            TestItem.Password = "Moo123";
            TestItem.Email = "Katie@gmail.com";
            //set ThisCustomerto the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            // test to see that it isnt there
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByFullname()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByFullname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullnameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a full name that doesn't exist
            FilteredCustomers.ReportByFullname("Xxxxxxxx Xxxxxxx");
            //test to see that therer are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullnameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Fullname that doesn't exist
            FilteredCustomers.ReportByFullname("YYYYY YYYYY");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID3
                if (FilteredCustomers.CustomerList[0].CustomerID != 3)
                {
                    OK = false;
                }
                //check that the first record is ID4
                if (FilteredCustomers.CustomerList[1].CustomerID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}