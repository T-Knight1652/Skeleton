using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

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

        public clsStaff ThisStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();        
            //execute the stored data connection
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create the items of the test data
                clsStaff staff = new clsStaff();
                //raed in the fiels from the current record
                staff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["Manager"]);
                staff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                staff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                staff.MonthlySalary = Convert.ToInt32(DB.DataTable.Rows[Index]["MonthlySalary"]);
                staff.StartJob = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartJob"]);
                //add the item to the test list
                mStaffList.Add(staff);
                //point at the next record
                Index++;
            }
        }

        


    }
}