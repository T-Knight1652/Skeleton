using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
        }
    }

    //protected void chkActive_CheckedChanged(object sender, EventArgs e)
    //{
    //
    //}

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier aSupplier = new clsSupplier();
        //capture the brand name
        string BrandName = txtBrandName.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the total
        string Total = txtTotal.Text;
        //capture the active
        //string Active = chkActive.Checked;
        //capture the next delivery date
        string NextDelivery = txtNextDelivery.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aSupplier.Valid(BrandName, Quantity, Total, NextDelivery);
        if (Error == "")
        {
            //capture the product id
            aSupplier.ProductID = ProductID;
            //capture the brand name
            aSupplier.BrandName = BrandName;
            //capture the quantity
            aSupplier.Quantity = Convert.ToInt32(Quantity);
            //capture the total
            aSupplier.Total = Convert.ToDouble(Total);
            //capture the active
            aSupplier.Active = chkActive.Checked;
            //capture the next delivery
            aSupplier.NextDelivery = Convert.ToDateTime(NextDelivery);
            //create a new instance of the supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();

            //if this is a new record i.e. ProductID = -1 then add the data
            if (ProductID == -1)
            {
                //set the ThisSupplier Property
                SupplierList.ThisSupplier = aSupplier;
                //add the new record
                SupplierList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                SupplierList.ThisSupplier.Find(ProductID);
                //set the ThisSupplier property
                SupplierList.ThisSupplier = aSupplier;
                //update the record
                SupplierList.Update();
                
            }
            //redirect back to the listpage
            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        //create an instance of the supplier class
        clsSupplier aSupplier = new clsSupplier();
        //variable to store the primary key
        Int32 ProductID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        //find the record
        Found = aSupplier.Find(ProductID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtBrandName.Text = aSupplier.BrandName;
            txtQuantity.Text = aSupplier.Quantity.ToString();
            txtTotal.Text = aSupplier.Total.ToString();
            txtNextDelivery.Text = aSupplier.NextDelivery.ToString();
        }
        else
        {
            lblError.Text = "Record not found";
        } 
    }

    void DisplaySupplier()
    {
        //create an instance of the supplier collection class
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        //find the record to update
        SupplierList.ThisSupplier.Find(ProductID);
        //display the data for this record
        txtProductID.Text = SupplierList.ThisSupplier.ProductID.ToString();
        txtBrandName.Text = SupplierList.ThisSupplier.BrandName;
        txtQuantity.Text = SupplierList.ThisSupplier.Quantity.ToString();
        txtTotal.Text = SupplierList.ThisSupplier.Total.ToString();
        txtNextDelivery.Text = SupplierList.ThisSupplier.NextDelivery.ToString();
        chkActive.Checked = SupplierList.ThisSupplier.Active;
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the listpage
        Response.Redirect("SupplierList.aspx");
    }
}