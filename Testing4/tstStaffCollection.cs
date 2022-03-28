using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_FrameWork
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property,
            //in this case the data eeds to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list, create the item of the test data
            clsStaff TestItem = new clsStaff();

            //set its properties
            TestItem.Manager = true;
            TestItem.FullName = "Sabrina Gates";
            TestItem.Department = "Sales";
            TestItem.MonthlySalary = 1500;
            TestItem.StartJob = DateTime.Now.Date;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property, in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list, create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Manager = true;
            TestItem.FullName = "Sabrina Gates";
            TestItem.Department = "Sales";
            TestItem.MonthlySalary = 1500;
            TestItem.StartJob = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisStaffProperyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the propery
            clsStaff TestStaff = new clsStaff();

            //set the properties of the test object
            TestStaff.Manager = true;
            TestStaff.FullName = "Sabrina Gates";
            TestStaff.Department = "Sales";
            TestStaff.MonthlySalary = 1500;
            TestStaff.StartJob = DateTime.Now.Date;

            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void AddMethodOkOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of  test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set the properties of the test object
            TestItem.Manager = false;
            TestItem.FullName = "Tom Holland";
            TestItem.Department = "Marketing";
            TestItem.MonthlySalary = 2200;
            TestItem.StartJob = DateTime.Now.Date;

            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.EmployeeId = PrimaryKey;
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the 2 valus are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);


        }






        }
}
    
