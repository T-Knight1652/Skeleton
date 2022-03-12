using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        public clsStockCollection()
        {
            clsStockCollection testStock = new clsStockCollection();
             
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