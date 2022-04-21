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
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        ListItem item;

        String columns = "{0, -15}{1, -26}{2, -26}"; //https://stackoverflow.com/questions/2646446/multiple-columns-in-list-box-control

        String format = Server.HtmlDecode(String.Format(columns, "Product ID", "Brand Name", "Next Delivery").Replace(" ", "&nbsp;")); //https://stackoverflow.com/questions/2978311/format-a-string-into-columns
        item = new ListItem(format, "1");
        lstSupplierList.Items.Add(item);

        for (int i = 0; i < Suppliers.SupplierList.Count; i++)
        {
            string ProductID = Suppliers.SupplierList[i].ProductID.ToString();
            string BrandName = Suppliers.SupplierList[i].BrandName;
            int count = 25 - BrandName.Length;

            string NextDelivery = Suppliers.SupplierList[i].NextDelivery.ToShortDateString();

            format = Server.HtmlDecode(String.Format(columns, ProductID, BrandName, NextDelivery).Replace(" ", "&nbsp;"));
            item = new ListItem(format, ProductID);
            lstSupplierList.Items.Add(item);
        }
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