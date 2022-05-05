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
        if (IsPostBack == false)
        {
            displayStocks();
        }
    }

    public void displayStocks()
    {
        clsStockCollection stocks = new clsStockCollection();
        lstStockList.DataSource = stocks.stockList;
        lstStockList.DataValueField = "productID";
        lstStockList.DataTextField = "productName";
        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["productID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 productID;
        if (lstStockList.SelectedIndex != -1)
        {
            productID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["productID"] = productID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 productID;
        if(lstStockList.SelectedIndex != -1)
        {
            productID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["productID"] = productID;
            Response.Redirect("StockConfirmDelete");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }



    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection stock = new clsStockCollection();
        stock.ReportBySupplierName(txtFilter.Text);
        lstStockList.DataSource = stock.stockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "supplierName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection stock = new clsStockCollection();
        stock.ReportBySupplierName("");
        txtFilter.Text = "";
        lstStockList.DataSource = stock.stockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "supplierName";
        lstStockList.DataBind();
    }
}
