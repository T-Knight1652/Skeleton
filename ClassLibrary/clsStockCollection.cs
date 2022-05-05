using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        




        }
            
        

        public int count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        

        public List<clsStock> stockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public clsStock thisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.productName);
            DB.AddParameter("@SupplierName", mThisStock.supplierName);
            DB.AddParameter("@QuantityAvailable", mThisStock.quantityAvailable);
            DB.AddParameter("@LastDelivery", mThisStock.lastDelivery);
            DB.AddParameter("@InStock", mThisStock.inStock);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.productID);
            DB.AddParameter("@ProductName", mThisStock.productID);
            DB.AddParameter("@SupplierName", mThisStock.supplierName);
            DB.AddParameter("@QuantityAvailable", mThisStock.quantityAvailable);
            DB.AddParameter("@LastDelivery", mThisStock.lastDelivery);
            DB.AddParameter("@InStock", mThisStock.inStock);
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.productID);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportBySupplierName(string supplierName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", supplierName);
            DB.Execute("sproc_tblStock_FilterBySupplierName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 index = 0;
            Int32 recordCount;
            recordCount = DB.Count;
            mStockList = new List<clsStock>();
            while(index < recordCount)
            {
                clsStock aStock = new clsStock();
                aStock.productID = Convert.ToInt32(DB.DataTable.Rows[index]["productID"]);
                aStock.productName = Convert.ToString(DB.DataTable.Rows[index]["productName"]);
                aStock.supplierName = Convert.ToString(DB.DataTable.Rows[index]["supplierName"]);
                aStock.quantityAvailable = Convert.ToInt32(DB.DataTable.Rows[index]["quantityAvailable"]);
                aStock.lastDelivery = Convert.ToDateTime(DB.DataTable.Rows[index]["lastDelivery"]);
                aStock.inStock = Convert.ToBoolean(DB.DataTable.Rows[index]["inStock"]);
                mStockList.Add(aStock);
                index++;
            }
        }
    }
}