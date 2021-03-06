using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer) Session["ACustomer"];
        //display the fullname for this entry
        Response.Write(ACustomer.Fullname);
        Response.Write(ACustomer.Password);
        Response.Write(ACustomer.Email);
        Response.Write(ACustomer.CreationDate);
    }
}