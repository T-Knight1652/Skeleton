using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
            {
            get
            { 
            //return the private data
            return mOrderList;
            } set
            {
                //set the private data 
            mOrderList = value;
            } }
        public clsOrder ThisOrder { get; set; }
        public int Count {
            get
            { 
            //return the count of the list 
            return mOrderList.Count;
            }
               set
                {
            //needs adding
                }
        }
        //constructor for the class 
        public clsOrderCollection()
        {
            //var fpr the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount =0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process 
            while(Index < RecordCount)
            { 
            //create a blank order
            clsOrder order = new clsOrder();
                //read in the fields from the curren record
                order.Dispatch = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatch"]);
                order.Comments = Convert.ToString(DB.DataTable.Rows[Index]["Comments"]);
                order.Item = Convert.ToString(DB.DataTable.Rows[Index]["Item"]);
                order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                order.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                order.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mOrderList.Add(order);
                //point at the next record
                Index++;

            }
        }
    }
}