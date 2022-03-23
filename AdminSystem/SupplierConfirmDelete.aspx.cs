using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key of the record to be deleted
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier collection class
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        //find the record to delete
        SupplierList.ThisSupplier.Find(ProductID);
        //delete the record
        SupplierList.Delete();
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }
}