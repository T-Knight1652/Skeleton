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
        //create a new insrance of clsSupplier
        clsSupplier aSupplier = new clsSupplier();
        //get the data from the session object
        aSupplier = (clsSupplier)Session["aSupplier"];
        //display the house number for this entry
        Response.Write(aSupplier.BrandName);
        Response.Write(aSupplier.Quantity);
        Response.Write(aSupplier.Total);
        Response.Write(aSupplier.NextDelivery);
        Response.Write(aSupplier.Active);
    }
}