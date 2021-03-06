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
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FullName = "";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(49, 'a');            
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');            
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);           
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(25, 'a');            
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');//this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartJobExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string StartJob = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartJobMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StartJob = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartJobMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StartJob = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartJobMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StartJob = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartJobExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StartJob = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartJobInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the StartJob to a non date value
            string StartJob = "This is not a date!";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Department = "";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "a"; //this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "aa"; //this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(49, 'a');
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(50, 'a');
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(25, 'a');
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(51, 'a');//this should be ok
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MonthlySalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String MonthlySalary = "-10000000";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MonthlySalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String MonthlySalary = "-0.01";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MonthlySalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String MonthlySalary = "0.00";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MonthlySalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String MonthlySalary = "0.01";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MonthlySalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String MonthlySalary = "Bill";
            //invoke the method
            Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





    }

}
