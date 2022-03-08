using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int mProductID;
        private Int32 mQuantityAvailable;
        private string mProductName;
        private string mSupplierName;
        public bool mInStock;
        public DateTime mLastDelivery;

        public string productName
        {
            get
            {
                return mProductName;

            }

            set
            {
                mProductName = value;
            }
        }
        public string supplierName
        {

            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        public bool inStock
        {
            get
            {
                return mInStock;
            }

            set
            {
                mInStock = value;
            }
        }
        public int quantityAvailable
        {
            get
            {
                return mQuantityAvailable;
            }
            set
            {
                mQuantityAvailable = value;
            }
        }
        public DateTime lastDelivery
        {
            get
            {
                return mLastDelivery;
            }
            set
            {
                mLastDelivery = value;
            }
        }

        public int productID
        {
            get
            {
                return mProductID;
            }

            set
            {
                mProductID = value;
            }
        }

        public bool Find(int productID)
        {

            mProductID = 1;
            mQuantityAvailable = 23;
            mProductName = "Fanta orange";
            mSupplierName = "Fanta";
            mLastDelivery = Convert.ToDateTime(06 / 03 / 2022);
            mInStock = true;
            return true;
        }

        
    }
}