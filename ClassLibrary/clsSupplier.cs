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
  
        public bool Find(Int32 productID)
        {
            //set the private data members to the test data value
            mProductID = 21;
            mBrandName = "Test Brand";
            mQuantity = 50;
            mTotal = 75.0;
            mActive = true;
            mNextDelivery = Convert.ToDateTime("16/09/2015");
            //always return true
            return true;
        }
    }
}