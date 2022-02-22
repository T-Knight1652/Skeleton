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

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier aSupplier = new clsSupplier();
        //capture the brand name
        aSupplier.BrandName = txtBrandName.Text;
        //capture the quantity
        aSupplier.Quantity = Convert.ToInt32(txtQuantity.Text);
        //capture the total
        aSupplier.Total = Convert.ToDouble(txtTotal.Text);   
        //capture the active
        aSupplier.Active = chkActive.Checked;
        //capture the next delivery date
        aSupplier.NextDelivery = Convert.ToDateTime(txtNextDelivery.Text);
        //store the brand name in the session object
        Session["aSupplier"] = aSupplier;
        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }

    
}