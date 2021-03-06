using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 OrderID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection order = new clsOrderCollection();
        //find the record to delete 
        order.ThisOrder.Find(OrderID);
        //delete the record 
        order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main data entry page
        Response.Redirect("OrderList.aspx");
    }
}