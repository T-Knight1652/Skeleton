using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the address no property
        private Int32 mProductID;
        //private data member for the brand name property
        private String mBrandName;
        //private data member for the quantity property
        private Int32 mQuantity;
        //private data member for the total property
        private Double mTotal;
        //private data member for the active property
        private Boolean mActive;
        //private data member for the next delivery property
        private DateTime mNextDelivery;

        //ProductID public property
        public Int32 ProductID
        {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }
        //BrandName public property
        public string BrandName
        {
            get
            {
                //this line of code sends data out of the property
                return mBrandName;
            }
            set
            {
                //this line of code allows data into the property
                mBrandName = value;
            }
        }
        //Quantity public property
        public int Quantity 
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }
        //Total public property
        public double Total
        {
            get
            {
                //this line of code sends data out of the property
                return mTotal;
            }
            set
            {
                //this line of code allows data into the property
                mTotal = value;
            }
        }
        //Active public property
        public bool Active 
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        //NextDelivery public property
        public DateTime NextDelivery
        {
            get
            {
                //this line of code sends data out of the property
                return mNextDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mNextDelivery = value;
            }
        }
  
        public bool Find(int ProductID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByProductID");
            //if one record if found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mBrandName = Convert.ToString(DB.DataTable.Rows[0]["BrandName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotal = Convert.ToDouble(DB.DataTable.Rows[0]["Total"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mNextDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["NextDelivery"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }
}