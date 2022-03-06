using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customerID property
        private Int32 mCustomerID;
        private DateTime mCreationDate;
        private Boolean mOverEighteen;
        private string mEmail;
        private string mFullname;
        private string mPassword;
        //CustomerID public property
        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }


        //CreationDate public property
        public DateTime CreationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mCreationDate;
            }
            set
            {
                //this line of code allows data into the property
                mCreationDate = value;
            }
        }


        //OverEighteen public property
        public Boolean OverEighteen
        {
            get
            {
                //this line of code sends data out of the property
                return mOverEighteen;
            }
            set
            {
                //this line of code allows data into the property
                mOverEighteen = value;
            }
        }

        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //Fullname public property
        public string Fullname
        {
            get
            {
                //this line of code sends data out of the property
                return mFullname;
            }
            set
            {
                //this line of code allows data into the property
                mFullname = value;
            }
        }

        //Password public property
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (its either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CreationDate"]);
                mOverEighteen = Convert.ToBoolean(DB.DataTable.Rows[0]["OverEighteen"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFullname = Convert.ToString(DB.DataTable.Rows[0]["Fullname"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}