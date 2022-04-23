using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
            {
            get
            { 
            //return the private data
            return mOrderList;
            } set
            {
                //set the private data 
            mOrderList = value;
            } }
        public clsOrder ThisOrder { get; set; }
        public int Count {
            get
            { 
            //return the count of the list 
            return mOrderList.Count;
            }
               set
                {
            //needs adding
                }
        }
        //constructor for the class 
        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.Comments = "some comments 1 ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 1";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 1;
            TestItem.Price = 1.00;
            //add the item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrder();
            //set is properties
            TestItem.Comments = "some comments 2 ";
            TestItem.Dispatch = true;
            TestItem.Item = "drink 2";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderID = 2;
            TestItem.Price = 2.00;
            //add th item to the test list
            mOrderList.Add(TestItem);
        }
    }
}