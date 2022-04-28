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


        [TestMethod]
        public void UpdateMethodOK()
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

            //modify the test data
            TestItem.Manager = true;
            TestItem.FullName = "Ally Hunter";
            TestItem.Department = "Accounting and Finance";
            TestItem.MonthlySalary = 2500;
            TestItem.StartJob = DateTime.Now.Date;

            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of  test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
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
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByFullName("");
            //test to see that the 2 values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create the instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a full name that doesn't exist
            FilteredStaff.ReportByFullName("XXXX XXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create the instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name that doesn't exist
            FilteredStaff.ReportByFullName("YYY YYY");
            //Check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record ID 36
                if (FilteredStaff.StaffList[0].EmployeeId != 21)
                {
                    OK = false;
                }
                //chec that the first record is ID 37
                if (FilteredStaff.StaffList[1].EmployeeId != 22)
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
    
