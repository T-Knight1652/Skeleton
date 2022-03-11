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
     
        string productName = txtProductName.Text;
        string supplierName = txtSupplierName.Text;
        string quantityAvailable = txtQuantityAvailable.Text;
        string lastDelivery = txtLastDelivery.Text;
        string error = "";
        error = aStock.valid(productName, supplierName, quantityAvailable, lastDelivery);
        if (error == "")
        {
            aStock.productName = productName;
            aStock.supplierName = supplierName;
            aStock.quantityAvailable = Convert.ToInt32(quantityAvailable);
            aStock.lastDelivery = Convert.ToDateTime(lastDelivery);
            if (aStock.quantityAvailable > 0)
            {
                chkInStock.Checked = true;
            }
            else
            {
                chkInStock.Checked = false;
            }
            Session["aStock"] = aStock;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }
        
        
       
    }







    
}