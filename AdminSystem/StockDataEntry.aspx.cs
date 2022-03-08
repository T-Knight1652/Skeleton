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
        clsStock aStock = new clsStock();
     
        aStock.productName = txtProductName.Text;
        aStock.supplierName = txtSupplierName.Text;
        aStock.quantityAvailable = Convert.ToInt32(txtQuantityAvailable.Text);
        aStock.inStock = Convert.ToBoolean(chkInStock.Checked);
        aStock.lastDelivery = Convert.ToDateTime(txtLastDelivery.Text);

        Session["aStock"] = aStock;
        
        //Navigate to viewer page
        Response.Redirect("StockViewer.aspx");
    }







    
}