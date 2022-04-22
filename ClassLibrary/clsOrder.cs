using System;

namespace ClassLibrary 

{ 
    public class clsOrder 
    { 
        //private data member for the OrderID property 
        public Int32 mOrderID; 
        public DateTime mOrderDate; 
        public Boolean mDispatch; 
        public string mComments; 
        public Double mPrice; 
        public string mItem; 

        public string Item 
        { 
            get
            { 
                //return the private data  
                return mItem; 
            } 
            set 
            { 
                //set the private data 
                mItem = value; 
            } 
        } 
        public int OrderID 
        { 
            get 
            { 
                //sends data out of the property 
                return mOrderID; 
            } 
            set 
            { 
                //allows the data into the property 
                mOrderID = value; 
            } 
        } 
        public DateTime OrderDate 
        { 
            get 
            { 
                return mOrderDate; 
            } 
            set 
            { 
                mOrderDate = value; 
            } 
        }
        public Boolean Dispatch 
        { 
            get 
            {
                return mDispatch; 
            } 
            set 
            { 
                mDispatch = value; 
            } 
        } 
        public string Comments 
        { 
            get 
            { 
                return mComments; 
            } 
            set 
            { 
                mComments = value; 
            } 
        } 
        public Double Price 
        { 
            get 
            { 
                return mPrice;
            } 
            set 
            { 
                mPrice = value; 
            } 
        } 

        public bool Find(int orderID) 

        { 
            //create an instance of the data connection  
            clsDataConnection DB = new clsDataConnection(); 
            //add the parameter for the orderID to search for  
            DB.AddParameter("orderID", orderID); 
            //execute the stored procedure  
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be tiether one or zero) 
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]); 
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]); 
                mDispatch = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatch"]); 
                mComments = Convert.ToString(DB.DataTable.Rows[0]["Comments"]); 
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mItem = Convert.ToString(DB.DataTable.Rows[0]["Item"]); 
                //return that everything worked OK 
                return true; 
            } 
            //if no record was found  
            else 
            { 
                //return false indicating a problem 
                return false; 
            } 
        } 
        public string Valid(string comments, string price, string item, string orderDate) 
        { 
            //create a string variable to store the error 
            String Error = ""; 
            //create a temporary varialbe to store the date values 
            DateTime DateTemp;

            Double DoubleTemp;
            //---- the valid method for the item 
            //if the item is blank
            if (item.Length == 0) 
            { 
                //record the error 
                Error = Error + "the length of the ITem should not be left blank : "; 
            } 
            if (item.Length > 50) 
            { 
                //record the error 
                Error = Error + "the Item should not be more than 50 characters "; 
            } 
           //-------- the order date valid method  ---------------------------
            try 
            { 
                //copy the dateAdded value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(orderDate); 
                if (DateTemp < DateTime.Now.Date) 
                { 
                    //record the error 
                    Error = Error + "The date cannot be in the past : "; 
                } 
                // check to see if the date is greater than todays date 
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
            //--------the comments valid method  ---------------------------------
            //if the Comments is blank 
            if (comments.Length == 0) 
            { 
                //record the error 
                Error = Error + "The Comments can't be blank : "; 
            } 
            //if the comments is greater than 50 characters 
            if (comments.Length > 50) 
            { 
                //record the error 
                Error = Error + "The Comments can't be more than 50 characters ; "; 
            }
            //----------the price valid method  -------------------------------
            try
            {
                //copy the Total value to the DoubleTemp variable
                DoubleTemp = Convert.ToDouble(price);

                //if the value of total is less than 0
                if (DoubleTemp < 0)
                {
                    //record the error
                    Error = Error + "The inputted total value cannot be negative";
                } 

            }
            catch
            {
                //record the error
                Error = Error + "The inputted total value was invalid : ";
            }
            return Error;

        } 
    } 
    } 