using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member for thisSupplier
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList 
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set the private data
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database on the values of ThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BrandName", mThisSupplier.BrandName);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Total", mThisSupplier.Total);
            DB.AddParameter("@Active", mThisSupplier.Active);
            DB.AddParameter("@NextDelivery", mThisSupplier.NextDelivery);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisSupplier.ProductID);
            DB.AddParameter("@BrandName", mThisSupplier.BrandName);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Total", mThisSupplier.Total);
            DB.AddParameter("@Active", mThisSupplier.Active);
            DB.AddParameter("@NextDelivery", mThisSupplier.NextDelivery);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisSupplier.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByBrandName(string BrandName)
        {
            //filters the records based on a full or partial brand name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the BrandName parameter to the database
            DB.AddParameter("@BrandName", BrandName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByBrandName");
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
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsSupplier aSupplier = new clsSupplier();
                //read in the fields from the current record
                aSupplier.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                aSupplier.BrandName = Convert.ToString(DB.DataTable.Rows[Index]["BrandName"]);
                aSupplier.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                aSupplier.Total = Convert.ToDouble(DB.DataTable.Rows[Index]["Total"]);
                aSupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                aSupplier.NextDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["NextDelivery"]);
                //add the record to the private data member
                mSupplierList.Add(aSupplier);
                //point at the next record
                Index++;
            }
        }
    }
}