using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the fullname
        ACustomer.Fullname = txtFullname.Text;
        //store the fullname in the session object
        Session["ACustomer"] = ACustomer;
        //Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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
}