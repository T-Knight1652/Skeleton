using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayOrders();
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
}