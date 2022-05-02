using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList 
        {
            get
            {
                //return the private data 
                return mOrderList;
            } 
            set
            {
                //set the private data 
                mOrderList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list 
                return mOrderList.Count;
            } 
            set
            { 
            //done later
            } }
        public clsOrder ThisOrder {
            get
            {
                //return the private data 
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
                
            } }

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
     
            


        }

        public int Add()
        {
            //add a new record to the database based on teh values of thisOrder
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Comments", mThisOrder.Comments);
            DB.AddParameter("@Item", mThisOrder.Item);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Dispatch", mThisOrder.Dispatch);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //add a new record to the database based on teh values of thisOrder
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Comments", mThisOrder.Comments);
            DB.AddParameter("@Item", mThisOrder.Item);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Dispatch", mThisOrder.Dispatch);
            //execute the query returning the primary key
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the databasae 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stord procedure 
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByItem(string Item)
        {
            //filters the records based on the item
            // filters the records based on the item
            //connct to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the item parameter to the database
            DB.AddParameter("@Item", Item);
            //execute the stord procedure 
            DB.Execute("sproc_tblOrder_FilterByItem");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        
        void PopulateArray(clsDataConnection DB ) {
            //Populates the array list based on the data tabe in the parameter DB
            //populate teh array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //get the private array list 
            mOrderList = new List<clsOrder>();
            //whilt ethere are records to process 
            while (Index < RecordCount) 
            {
                //create a blank address
                clsOrder order = new clsOrder();
                //read in all the fileds from teh current record
                order.Comments = Convert.ToString(DB.DataTable.Rows[Index]["Comments"]);
                order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                order.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                order.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                order.Item = Convert.ToString(DB.DataTable.Rows[Index]["Item"]);
                order.Dispatch = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatch"]);
                //add tge record to the private data memeber 
                mOrderList.Add(order);
                //ppoint at the next record 
                Index++;
            }
        
        }
    }
}