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

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrder
        clsOrder order = new clsOrder();

        //capture the OrderID
       string OrderID = txtOrderID.Text;

        //capture the OrderDate
         string OrderDate = txtOrderDate.Text;

        //capture the Price 
        string Price = txtPrice.Text;
       
        //capture the dispatch
        string dispatch = chkDispatch.Text; //check if this is right

        //capture the comments
        string Comments = txtComments.Text;

        //capture the Item
        string Item = txtItem.Text;

        //a variable to store any error messages
        string Error = "";

        //validate the data 
        Error = order.Valid(Comments, Price, Item, OrderDate);
        if (Error == "")
        {
            order.Price = Convert.ToDouble(Price);
            order.OrderDate = Convert.ToDateTime(OrderDate);
            order.Item = Item;
            order.Comments = Comments;
            order.Dispatch = chkDispatch.Checked;
            //create a new instance of the order collection 
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = order;
            //add the new record 
            OrderList.Add();
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx ");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


       
    }

    protected void chkDispatch_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder order = new clsOrder();
        //cariable to store the primary key
        Int32 orderID;
        //cariable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key enetered by the user
        orderID = Convert.ToInt32(txtOrderID.Text);
        //find the record 
        Found = order.Find(orderID);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderID.Text = order.OrderID.ToString();
            txtOrderDate.Text = order.OrderDate.ToString();
            txtComments.Text = order.Comments;
            txtPrice.Text = order.Price.ToString();
            txtItem.Text = order.Item.ToString();
        }

    }
    //need to check something here
    protected void txtCustomer_TextChanged(object sender, EventArgs e)
    {

    }
}