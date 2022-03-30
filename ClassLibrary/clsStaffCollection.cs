using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //privatee data member thisStaff
        clsStaff mThisStaff = new clsStaff();


        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //complete later
            }
        }

        //public propert for ThisStaff
        public clsStaff ThisStaff 
        { 
            get
            {
                //return the private data
                return mThisStaff;
            } 
            set 
            {
                //set the private data
                mThisStaff = value;
            } 
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();        
            //execute the stored data connection
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@MonthlySalary", mThisStaff.MonthlySalary);
            DB.AddParameter("@StartJob", mThisStaff.StartJob);
            DB.AddParameter("@Manager", mThisStaff.Manager);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeId", mThisStaff.EmployeeId);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@MonthlySalary", mThisStaff.MonthlySalary);
            DB.AddParameter("@StartJob", mThisStaff.StartJob);
            DB.AddParameter("@Manager", mThisStaff.Manager);

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeId", mThisStaff.EmployeeId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FullName parameter to the database
            DB.AddParameter("@FullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullName");
            //populate the array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff staff = new clsStaff();
                //read in all the fields from the current record
                staff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["Manager"]);
                staff.EmployeeId = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeId"]);
                staff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                staff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                staff.MonthlySalary = Convert.ToInt32(DB.DataTable.Rows[Index]["MonthlySalary"]);
                staff.StartJob = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartJob"]);
                //add the record to the private data member
                mStaffList.Add(staff);
                //point at the next record
                Index++;
            }
        }
    }
}