using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 EmployeeId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Employee to be delete from the session object
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Staff collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(EmployeeId);
        //delete the record
        StaffBook.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

}