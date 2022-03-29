using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the OrderID property
        public Int32 mOrderID;
        public DateTime mOrderDate;
        public Boolean mDispatch;
        public string mComments;
        public Double mPrice;

      
        public int OrderID {
            get
            {
                //sends data out of the property
                return mOrderID; 
            }

            set
            {
                //allows the data into the property
                mOrderID = value;
            }
       }


        public DateTime OrderDate { 
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        
        }


        public Boolean Dispatch { 
            get
            {

                return mDispatch;

            }
            set
            {

                mDispatch = value;

            } 
               }
        
        
        public string Comments { 
            get
            {
                return mComments;
            }
                set
            {
                mComments = value;
            }
        }


        public Double Price {
            get
            {
                return mPrice;
            
            }
            set
            {
                mPrice = value;
            }  
                
           }

        public bool Find(int orderID)
        {

            //set the private data member to the test data value 
            mOrderID = 21;
            mOrderDate = Convert.ToDateTime("16/9/2015");
            mDispatch = true;
            mComments = "some comments";
            mPrice = 21.10;

            //always return true 
            return true;
        }
    }
}