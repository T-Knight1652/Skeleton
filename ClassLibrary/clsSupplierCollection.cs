using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

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
        public clsSupplier ThisSupplier { get; set; }

        public clsSupplierCollection()
        {
            //create the items of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.ProductID = 1;
            TestItem.BrandName = "some brandname";
            TestItem.Quantity = 50;
            TestItem.Total = 69.99;
            TestItem.Active = true;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(2);
            //add the item to the test list
            mSupplierList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsSupplier();
            //set its properties
            TestItem.ProductID = 2;
            TestItem.BrandName = "another brandname";
            TestItem.Quantity = 70;
            TestItem.Total = 104.36;
            TestItem.Active = false;
            TestItem.NextDelivery = DateTime.Now.Date.AddDays(1);
            //add the item to the test list
            mSupplierList.Add(TestItem);


            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
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
                //point to the next record
                Index++;
            }


        }
    }
}