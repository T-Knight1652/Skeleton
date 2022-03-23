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
    }
}
