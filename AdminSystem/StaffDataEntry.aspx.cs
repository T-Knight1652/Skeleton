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
        string FullName = txtFullName.Text;
        //Capture the department
        string Department = txtDepartment.Text;
        //Capture the monthly salary
        string MonthlySalary = txtMonthlySalary.Text;
        //Capture the start date of the job
        string StartJob = txtStartJob.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = staff.Valid(FullName, Department, MonthlySalary, StartJob);
        if (Error == "")
        {
            //capture the full name
            staff.FullName = FullName;
            //capture the department
            staff.Department = Department;
            //capture the MonthlySalary
            staff.MonthlySalary = Convert.ToInt32(MonthlySalary);
            //capture the StartJob
            staff.StartJob = Convert.ToDateTime(StartJob);
            //capture the manager
            staff.Manager = chkManager.Checked;

            //store the full name in the session object
            Session["staff"] = staff;
            //redirect to the viewer page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        

        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff staff = new clsStaff();
        //variable to store the primary key
        Int32 EmployeeId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered bu the user
        EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
        //find the record
        Found = staff.Find(EmployeeId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFullName.Text = staff.FullName;
            txtDepartment.Text = staff.Department;
            txtMonthlySalary.Text = staff.MonthlySalary.ToString();
            txtStartJob.Text = staff.StartJob.ToString();
        }
        else
        {
            lblError.Text = "No match data";
        }

    }
}