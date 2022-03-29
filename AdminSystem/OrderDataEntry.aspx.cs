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

        //create a new instance of clsOrder
        clsOrder order = new clsOrder();

        //capture the OrderID
       string OrderID = txtOrderID.Text;

        //capture the OrderDate
         string OrderDate = txtOrderDate.Text;
       



        //capture the Price 
        string Price = txtPrice.Text;
       


        //capture the dispatch
        string dispatch = chkDispatch.Text; //check if this is right
       

        //capture the comments
           string Comments = txtComments.Text;
      
       

        //store the order in the session object
        Session["order"] = order;


        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void chkDispatch_CheckedChanged(object sender, EventArgs e)
    {

    }
}