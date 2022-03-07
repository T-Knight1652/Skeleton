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
        clsStock aStock = new clsStock();
        aStock = (clsStock)Session["aStock"];
        Response.Write(aStock.productID);
        Response.Write(aStock.productName);
        Response.Write(aStock.supplierName);
        Response.Write(aStock.quantityAvailable);
        Response.Write(aStock.inStock);

        Response.Write(aStock.lastDelivery);


    }
}