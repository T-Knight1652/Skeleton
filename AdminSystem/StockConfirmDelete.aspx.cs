using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 productID;
    protected void Page_Load(object sender, EventArgs e)
    {
        productID = Convert.ToInt32(Session["productID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection stock = new clsStockCollection();
        stock.thisStock.Find(productID);
        stock.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}