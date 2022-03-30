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
            DisplayStaff();
        }
    }

        void DisplayStaff()
        {
            //create an instance of the staff collection
            clsStaffCollection staff = new clsStaffCollection();
            //set the data source to list of staff in the collection
            lstStaffList.DataSource = staff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "EmployeeId";
            //set the data field to display
            lstStaffList.DataTextField = "FullName";
            //bind th data to the list
            lstStaffList.DataBind();
        }



    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is anew record
        Session["EmployeeId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to the edited
        Int32 EmployeeId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key values of the record to edit
            EmployeeId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["EmployeeId"] = EmployeeId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        } 
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 EmployeeId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            EmployeeId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the sssion object
            Session["EmployeeId"] = EmployeeId;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        } 
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection staff = new clsStaffCollection();
        staff.ReportByFullName("");
        //clear any existing filter to tidy up the inteface
        txtFilter.Text = "";
        lstStaffList.DataSource = staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "EmployeeId";
        //set the name of the fiels to diplay
        lstStaffList.DataTextField = "FullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection staff = new clsStaffCollection();
        staff.ReportByFullName(txtFilter.Text);
        lstStaffList.DataSource = staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "EmployeeId";
        //set the name of the fiels to diplay
        lstStaffList.DataTextField = "FullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}