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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@productID", productID);
            DB.Execute("sproc_tblStock_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["productID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["productName"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["supplierName"]);
                mQuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["quantityAvailable"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["inStock"]);
                mLastDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["lastDelivery"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}