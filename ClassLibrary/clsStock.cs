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

        public string valid(string productName, string supplierName, string quantityAvailable, string lastDelivery)
        {
            string error = "";
            if (productName.Length == 0) 
            {
                error = error + "Product name must be at least 1 character long ";
            }

            if (productName.Length > 30)
            {
                error = error + "Product name must be under 30 characters ";
            }

            if (supplierName.Length == 0)
            {
                error = error + "Supplier name must be at least 1 character long ";
            }

            if (supplierName.Length > 30)
            {
                error = error + "Supplier name must be under 30 characters ";
            }
            try
            {
                DateTime dateTemp = Convert.ToDateTime(lastDelivery);
                if (dateTemp < DateTime.Now.Date)
                {
                    error = error + "Date cannot be in the past ";
                }

                if (dateTemp > DateTime.Now.Date)
                {
                    error = error + "Date cannot be in the future ";
                }
            }
            catch
            {
                error = error + "Must be a date";
            }

            try
            {
                int tempInt = Convert.ToInt32(quantityAvailable);
                if(tempInt < 0)
                {
                    error = error + "Quantity available cannot be negative";
                }

                if (tempInt > 10000)
                {
                    error = error + "Quantity available cannot be over 10000";
                }
            }
            catch
            {
                error = error + "Quantity available must be an integer";
            }
            return error;
        }
    }

}