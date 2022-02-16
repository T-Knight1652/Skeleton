using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSatff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(staff);

        }

        [TestMethod]
        public void ManagerPropertOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Create some test data
            Boolean TestData = true;
            //Assign the data to the property
            staff.Manager = TestData;
            //test to see if the two values ar the same
            Assert.AreEqual(staff.Manager, TestData);
        }

        [TestMethod]
        public void StartJobPropertOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Create some test data
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            staff.StartJob = TestData;
            //test to see if the two values ar the same
            Assert.AreEqual(staff.StartJob, TestData);
        }

        [TestMethod]
        public void MonthlySalaryPropertOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Create some test data
            int TestData = 1;
            //Assign the data to the property
            staff.MonthlySalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.MonthlySalary, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales";
            //assign the data to the property
            staff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.Department, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Bill Gates";
            //assign the data to the property
            staff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.FullName, TestData);
        }



    }

}
