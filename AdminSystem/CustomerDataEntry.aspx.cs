using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the fullname
        string Fullname = txtFullname.Text;
        string Password = txtPassword.Text;
        string Email = txtEmail.Text;
        string CreationDate = txtCreationDate.Text;
        //variable to store error message
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(Password, Fullname, Email, CreationDate);
        if (Error =="")
        {
            //capture the values
            ACustomer.CustomerID = CustomerID;
            ACustomer.Fullname = Fullname;
            ACustomer.Password = Password;
            ACustomer.Email = Email;
            ACustomer.CreationDate = Convert.ToDateTime(CreationDate);
            ACustomer.OverEighteen = chkOverEighteen.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        try
        {
            CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //find the record
            Found = ACustomer.Find(CustomerID);
        }    
        catch (FormatException){
            lblError.Text = "Invalid format for CustomerID";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtCreationDate.Text = "";
        }



        //if found
        int numericValue;
        bool isNumber = int.TryParse(txtCustomerID.Text, out numericValue);
        if (Found == true)
        {
            lblError.Text = "";
            //display the values of the properties in the form
            txtPassword.Text = ACustomer.Password;
            txtFullname.Text = ACustomer.Fullname;
            txtEmail.Text = ACustomer.Email;
            txtCreationDate.Text = ACustomer.CreationDate.ToString();
            chkOverEighteen.Checked = ACustomer.OverEighteen;
        }
        else if (isNumber)
        {
            lblError.Text = "CustomerID does not exist";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtCreationDate.Text = "";
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customerCollection
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = Customer.ThisCustomer.CustomerID.ToString();
        txtPassword.Text = Customer.ThisCustomer.Password;
        txtFullname.Text = Customer.ThisCustomer.Fullname;
        txtEmail.Text = Customer.ThisCustomer.Email;
        txtCreationDate.Text = Customer.ThisCustomer.CreationDate.ToString();
        chkOverEighteen.Checked = Customer.ThisCustomer.OverEighteen;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}