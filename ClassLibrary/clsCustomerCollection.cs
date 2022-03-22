using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //do this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Fullname", mThisCustomer.Fullname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@CreationDate", mThisCustomer.CreationDate);
            DB.AddParameter("@OverEighteen", mThisCustomer.OverEighteen);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Fullname", mThisCustomer.Fullname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@CreationDate", mThisCustomer.CreationDate);
            DB.AddParameter("@OverEighteen", mThisCustomer.OverEighteen);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullname(string Fullname)
        {
            //filters the records based on a full or partial fullname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Fullname parameter to the database
            DB.AddParameter("@Fullname", Fullname);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullname");
            //populate the array list with the data table
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
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in all the fields from the current record
                ACustomer.OverEighteen = Convert.ToBoolean(DB.DataTable.Rows[Index]["OverEighteen"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Fullname = Convert.ToString(DB.DataTable.Rows[Index]["Fullname"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.CreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreationDate"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}