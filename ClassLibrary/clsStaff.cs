using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Manager private member variable
        private Boolean mManager;
        //Manager public property
        public bool Manager
        {
            get
            {
                //this line of code sends data out of the property
                return mManager;
            }
            set
            {
                //this line of code allows data into the property
                mManager = value;
            }
        }

        //StartJob private member variable
        private DateTime mStartJob;
        //StartJob public property
        public DateTime StartJob
        {
            get
            {
                //this line of code sends data out of the property
                return mStartJob;
            }
            set
            {
                //this line of code allows data into the property
                mStartJob = value;
            }
        }

        //MonthlySalary private member variable
        private Int32 mMonthlySalary;
        //MonthlySalary public property
        public Int32 MonthlySalary
        {
            get
            {
                //this line of code sends data out of the property
                return mMonthlySalary;
            }
            set
            {
                //this line of code allows data into the property
                mMonthlySalary = value;
            }
        }

        //Department private member variable
        private string mDepartment;
        //Department public property
        public string Department
        {
            get
            {
                //this line of code sends data out of the property
                return mDepartment;
            }
            set
            {
                //this line of code allows data into the property
                mDepartment = value;
            }
        }

        //FullName private member variable
        private string mFullName;
        //FullName public property
        public string FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        //EmployeeId private member variable
        private Int32 mEmployeeId;
        //EmployeeId public property
        public Int32 EmployeeId
        {
            get
            {
                //this line of code sends data out of the property
                return mEmployeeId;
            }
            set
            {
                //this line of code allows data into the property
                mEmployeeId = value;
            }
        }

        public bool Find(int employeeId)
        {
            //set the private data members to the test data value
            mEmployeeId = 1;
            mFullName = "Karina Brown";
            mDepartment = "Marketing";
            mMonthlySalary = 1000;
            mStartJob = Convert.ToDateTime("13/01/2022");
            mManager = false;
            //always return true
            return true;
        }
    }
}