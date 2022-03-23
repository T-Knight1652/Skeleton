using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.ProductID = 1;
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierProperty()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.ProductID = 1;
            TestSupplier.BrandName = "some brandname";
            TestSupplier.Quantity = 50;
            TestSupplier.Total = 69.99;
            TestSupplier.Active = true;
            TestSupplier.NextDelivery = DateTime.Now.Date.AddDays(2);
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.ProductID = 1;
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.ProductID = 1;
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //modify the test data
            TestItem.BrandName = "another brandname";
            TestItem.Quantity = 30;
            TestItem.Total = 49.99;
            TestItem.Active = false;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(1);
            //set the record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            //Update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see ThisSupplier matches the test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //delete the record
            AllSuppliers.Delete();
            //now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByBrandNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string (should return all results)
            FilteredSuppliers.ReportByBrandName("generic brandname");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByBrandNameTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a brand name that doesnt exist
            FilteredSuppliers.ReportByBrandName("Lucozade");
            //check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredSuppliers.SupplierList[0].ProductID != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 3
                if (FilteredSuppliers.SupplierList[1].ProductID != 3)
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
