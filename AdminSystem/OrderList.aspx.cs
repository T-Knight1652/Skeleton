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
            if (OrderID != -1) //page 17 this was not here 
            { 
            //display  the current data for the record 
            DisplayOrders();
            }
        }

    }

    void DisplayOrders()
    {
        //create an instance of the Order Collection 
        clsOrderCollection order = new clsOrderCollection();
        //set the data source to list of orders in the collection 
        lstOrderList.DataSource = order.OrderList;
        //sest the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "Comments";
        //bind the data to the list 
        lstOrderList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //add method
        Session["OrderID"] = -1;
        //redirect to the data entry page
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

    protected void btnDelete_Click(object sender, EventArgs e)
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
            //redirect to the delete page 
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else // if no records have been selected 
        {
            lblError.Text = "Plrease select a record to delete from the list ";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of th order collection 
        clsOrderCollection order = new clsOrderCollection();
        order.ReportByItem(txtFilter.Text);
        lstOrderList.DataSource = order.OrderList;
        //set the naem of the primrary key
        lstOrderList.DataValueField = "OrderID";
        //set the nam eof th field to display
        lstOrderList.DataTextField = "Item";
        //bind the data to tht list
        lstOrderList.DataBind();
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of th order collection 
        clsOrderCollection orders = new clsOrderCollection();
        orders.ReportByItem("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "Item";
        //bind the dat to the list 
        lstOrderList.DataBind();

    }
}