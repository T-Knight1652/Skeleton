using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clcStaff
        clsStaff staff = new clsStaff();
        //gt the data from the session object
        staff = (clsStaff) Session["staff"];

        //display the full name for this entry
        Response.Write(staff.FullName);
        Response.Write(staff.Department);
        Response.Write(staff.MonthlySalary);
        Response.Write(staff.StartJob);
        Response.Write(staff.Manager);
    }
}