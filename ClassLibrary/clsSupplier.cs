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

        public string Valid(string brandName,
                            string quantity,
                            string total,
                            string nextDelivery)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store integer values
            Int32 IntTemp;
            //create a temporary variable to store float values
            Double DoubleTemp;
            //create a temporary variable to store date values
            DateTime DateTemp;

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~ BrandName Validation ~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //if the BrandName is blank
            if (brandName.Length == 0) 
            {
                //record the error
                Error = Error + "The brand name may not be blank : ";
            }

            //if the BrandName is greater than 50 characters
            if (brandName.Length > 50)
            {
                //record the error
                Error = Error + "The brand name is too long : ";
            }

            //if the BrandName is only 1 character
            if (brandName.Length == 1)
            {
                //record the error
                Error = Error + "The brand name is too short : ";
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Quantity Validation ~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            try
            {
                //copy the quantity value to the IntTemp variable
                IntTemp = Convert.ToInt32(quantity);

                //if the value of quantity is less than 2
                if (IntTemp < 2)
                {
                    //record the error
                    Error = Error + "Entered quantity value is too low : ";
                }

                //if the value of quantity is greater than the max value of int32
                if (IntTemp > 2147483647)
                {
                    //record the error
                    Error = Error + "Entered quantity value is too big";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The inputted quantity value was invalid : ";
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Total Validation ~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            try
            {
                //copy the Total value to the DoubleTemp variable
                DoubleTemp = Convert.ToDouble(total);

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

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~ NextDelivery Validation ~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            try
            {
                //copy the NextDelivery value to the DateTemp variable
                DateTemp = Convert.ToDateTime(nextDelivery);

                //if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The inputted date value was invalid : ";
            }

            //return any error messages
            return Error;
        }
    }
}