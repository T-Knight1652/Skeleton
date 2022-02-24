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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff staff = new clsStaff();
        //Capture the full name
        staff.FullName = txtFullName.Text;
        //Capture the department
        staff.Department = txtDepartment.Text;
        //Capture the monthly salary
        staff.MonthlySalary = (int)Convert.ToDouble(txtMonthlySalary.Text);
        //Capture the start date of the job
        staff.StartJob = Convert.ToDateTime(txtStartJob.Text);
        //Capture the manager check box
        staff.Manager = chkManager.Checked;

        // store the full name in the session object
         Session["staff"] = staff;

        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}