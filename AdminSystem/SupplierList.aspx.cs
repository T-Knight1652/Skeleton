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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        //create an instance of the Supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "ProductID";
        //set the data field to display
        lstSupplierList.DataTextField = "BrandName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the edit page
            Response.Redirect("SupplierDataEntry.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the delete page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportByBrandName(txtFilter.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "ProductID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "BrandName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportByBrandName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "ProductID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "BrandName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }
}