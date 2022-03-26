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


        public clsStaffCollection()
        {
            //create the items of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Manager = true;
            TestItem.FullName = "Sabrina Gates";
            TestItem.Department = "Sales";
            TestItem.MonthlySalary = 1500;
            TestItem.StartJob = DateTime.Now.Date;
            //add the item to the test list
            mStaffList.Add(TestItem);
            //re initialize the object for some new data
            TestItem = new clsStaff();
            //set its properties
            TestItem.Manager = true;
            TestItem.FullName = "Sally Gill";
            TestItem.Department = "Marketing";
            TestItem.MonthlySalary = 1250;
            TestItem.StartJob = DateTime.Now.Date;
            //add the item to the list
            mStaffList.Add(TestItem);

        }


    }
}