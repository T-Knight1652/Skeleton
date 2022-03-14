using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSatff
    {
        //good test data
        //create some test data to pass to the method
        string FullName = "Karina Brown";
        string Department = "Marketing";
        string MonthlySalary = "1000";
        string StartJob = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void EmployeeIdPropertOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Create some test data
            int TestData = 1;
            //Assign the data to the property
            staff.EmployeeId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.EmployeeId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void testEmployeeIdFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.EmployeeId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testFullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.FullName != "Karina Brown")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.Department != "Marketing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testMonthlySalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.MonthlySalary != 1000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStartJobFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.StartJob != Convert.ToDateTime("13/01/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testManagerFound()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 EmployeeId = 1;
            //invoke the method
            Found = staff.Find(EmployeeId);
            //Check the EmployeeId
            if (staff.Manager != false)
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
            clsStaff staff = new clsStaff();
            //String variable to store any error message
            string Error = "";
            //invoke the method
            Error = staff.Valid(FullName,Department,MonthlySalary,StartJob);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }


    }

}
