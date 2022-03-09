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
        //create a new instance of clsOrder
        clsOrder order = new clsOrder();
        //get the data from hte session object
        order = (clsOrder)Session["order"];
        //display the comment for the entry
        Response.Write(order.Comments);

    }
}