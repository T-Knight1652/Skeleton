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

        public bool Find(int EmployeeId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the EmployeeId to search for
            DB.AddParameter("@EmployeeId", EmployeeId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByEmployeeId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mEmployeeId = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mMonthlySalary = Convert.ToInt32(DB.DataTable.Rows[0]["MonthlySalary"]);
                mStartJob = Convert.ToDateTime(DB.DataTable.Rows[0]["StartJob"]);
                mManager = Convert.ToBoolean(DB.DataTable.Rows[0]["Manager"]);
                //return if everything is ok
                return true;
            }
            //If no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }


        public string Valid(string fullName, string department, string monthlySalary, string startJob)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create a temporary variable to store float values
            Double DoubleTemp;

            //_________________________________FULL NAME VALID METHOD______________________________
            //if the full name is blank
            if (fullName.Length == 0)
            {
                //record the error
                Error = Error + "The full name may not be blank : ";
            }
            if (fullName.Length > 50)
            {
                //record the error
                Error = Error + "The full name must be less than 50 characters :  ";
            }


            //_________________________________START JOB VALID METHOD______________________________
            try
            {
                //copy the startjob value to the DateTemp variable
                DateTemp = Convert.ToDateTime(startJob);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //_________________________________DEPARTMENT VALID METHOD______________________________
            //if the department is blank
            if (department.Length == 0)
            {
                //record the error
                Error = Error + "The department may not be blank : ";
            }
            //if the department is longer than 50 characters
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department must be less than 50 characters :  ";
            }          

            //_________________________________MONTHLY SALARY VALID METHOD______________________________
            try
            {
                //copy the Monthly salary value to the DoubleTemp variable
                DoubleTemp = Convert.ToDouble(monthlySalary);

                //if the value of monthly salary is less than 0
                if (DoubleTemp < 0)
                {
                    //record the error
                    Error = Error + "The inputted monthly salary value cannot be negative : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The inputted monthly salary value was invalid : ";
            }

            //return any error messages
            return Error;
        }
    }
}