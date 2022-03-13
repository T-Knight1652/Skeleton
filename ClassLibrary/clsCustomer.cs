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

        public string Valid(string password, string fullname, string email, string creationDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varialbe to store the date values
            DateTime DateTemp;
            //if the Password is blank
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The password can't be blank : ";
            }
            //if the password is greater than 20 characters
            if (password.Length > 20)
            {
                //record the error
                Error = Error + "The password can't be more than 20 characters ; ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(creationDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the Fullname is blank
            if (fullname.Length == 0)
            {
                //record the error
                Error = Error + "The Fullname can't be blank : ";
            }
            //if the Fullname is greater than 30 characters
            if (fullname.Length > 30)
            {
                //record the error
                Error = Error + "The fullname can't be more than 30 characters ; ";
            }

            //if the Email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email can't be blank : ";
            }
            //if the email is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The email can't be more than 50 characters ; ";
            }
            //return any error messages
            return Error;
        }
    }
}