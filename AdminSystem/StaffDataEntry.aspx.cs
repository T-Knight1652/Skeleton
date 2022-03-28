using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 EmployeeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (EmployeeId != 1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }

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
            //capture the employee id
            staff.EmployeeId = EmployeeId;
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
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. EmployeeId = -1 then add the data
            if (EmployeeId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = staff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(EmployeeId);
                //set the ThisStaff property
                StaffList.ThisStaff = staff;
                //update the record
                StaffList.Update();
            }
        
            //redirect to the viewer page
            Response.Redirect("StaffList.aspx");
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

    void DisplayStaff()
    {
        //create an instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(EmployeeId);
        //display the data for this record
        txtEmployeeId.Text = StaffBook.ThisStaff.EmployeeId.ToString();
        txtFullName.Text = StaffBook.ThisStaff.FullName;
        txtDepartment.Text = StaffBook.ThisStaff.Department;
        txtMonthlySalary.Text = StaffBook.ThisStaff.MonthlySalary.ToString();
        txtStartJob.Text = StaffBook.ThisStaff.StartJob.ToString();
        chkManager.Checked = StaffBook.ThisStaff.Manager;
    }
}