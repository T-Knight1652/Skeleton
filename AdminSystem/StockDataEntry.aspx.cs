using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 productID;
    protected void Page_Load(object sender, EventArgs e)
    {
        productID = Convert.ToInt32(Session["productID"]);
        if(IsPostBack == false)
        {
            if (productID != -1)
            {
                DisplayStock();
            }
        }

    }

    private void DisplayStock()
    {
        clsStockCollection stock = new clsStockCollection();
        stock.thisStock.Find(productID);
        txtProductID.Text = stock.thisStock.productID.ToString();
        txtProductName.Text = stock.thisStock.productName;
        txtSupplierName.Text = stock.thisStock.supplierName;
        txtQuantityAvailable.Text = stock.thisStock.quantityAvailable.ToString();
        txtLastDelivery.Text = stock.thisStock.lastDelivery.ToString();
        chkInStock.Checked = stock.thisStock.inStock;

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
            aStock.productID = productID;
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
            clsStockCollection stockList = new clsStockCollection();
            if(productID == -1)
            {
                stockList.thisStock = aStock;
                stockList.Add();
            }
            else
            {
                stockList.thisStock.Find(productID);
                stockList.thisStock = aStock;
                stockList.Update();
            }
           
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = error;
        }
        
        
       
    }









    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        Int32 productID;
        Boolean Found = false;
        productID = Convert.ToInt32(txtProductID.Text);
        

        

            Found = aStock.Find(productID);
            if (Found == true)
            {
                txtProductName.Text = Convert.ToString(aStock.productID);
                txtSupplierName.Text = aStock.supplierName;
                txtQuantityAvailable.Text = Convert.ToString(aStock.quantityAvailable);
                txtLastDelivery.Text = Convert.ToString(aStock.lastDelivery);
                if (aStock.quantityAvailable > 0)
                {
                    chkInStock.Checked = true;
                }
                else
                {
                    chkInStock.Checked = false;
                }
            }
        }
        
    


}
