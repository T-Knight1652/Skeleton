using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        public clsStockCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
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
            
        List<clsStock> mStockList = new List<clsStock>();

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

        public clsStock thisStock { get; set; }
    }
}