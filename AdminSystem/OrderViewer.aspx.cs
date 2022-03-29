using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsOrder order = new clsOrder();

        //get the data from the session object
        order = (clsOrder)Session["order"];

        //display the properties on the page
        Response.Write(order.OrderID);

        Response.Write(order.OrderDate);

        Response.Write(order.Price);

        Response.Write(order.Dispatch);

        Response.Write(order.Comments);
    }
}