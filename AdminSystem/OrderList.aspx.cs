using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            { 
            //display  the current data for the record 
            DisplayOrders();
            }
        }

    }

    private void DisplayOrders()
    {
        //create an instance of the Order Collection 
        clsOrderCollection order = new clsOrderCollection();
        //set the data source to list of orders in the collection 
        lstOrderList.DataSource = order.OrderList;
        //sest the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "Comments";
        lstOrderList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}