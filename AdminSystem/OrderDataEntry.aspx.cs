using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of order to be processes 
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //check if this is a new record
            if (OrderID != -1) 
            {
                //display the current dat aof the recrd
                DisplayOrder();
            }
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrder
        clsOrder order = new clsOrder();

        //capture the OrderDate
        string OrderDate = txtOrderDate.Text;
        //capture the Price 
        string Price = txtPrice.Text;
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
            if (OrderID == -1)
            {
                //set the ThisOrderProperty
                OrderList.ThisOrder = order;
                //add the new record 
                OrderList.Add();
            }//otherwise it msut be an update 
            else
            {
                //find the record to update 
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisAddress property
                OrderList.ThisOrder = order;
                //update the record 
                OrderList.Update();
            }
            //redirect back to the listpage 
            Response.Redirect("OrderList.aspx");
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
        //create an instance of the classs
        clsOrder order = new clsOrder();
        //variable to store the primary key 
        Int32 OrderID;
        //variable to store the restult of the find 
        Boolean Found = false;
        //get the primary key 
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            //find the record 
            Found = order.Find(OrderID);
        }
        catch (FormatException) 
        {
            lblError.Text = "Inva,id format for the OrderID";
            txtPrice.Text = "";
            txtComments.Text = "";
            txtItem.Text = "";
            txtOrderDate.Text = "";
        }

        if (Found == true)
        {
            lblError.Text = "";
            //display the values 
            txtPrice.Text = order.Price.ToString();
            txtComments.Text = order.Comments;
            txtItem.Text = order.Item;
            txtOrderDate.Text = order.OrderDate.ToString();
            chkDispatch.Checked = order.Dispatch;

        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        }

    void DisplayOrder()
    {
        //create an instace of the order collection 
        clsOrderCollection order = new clsOrderCollection();
        //find the record to update it 
        order.ThisOrder.Find(OrderID);
        //dispalay the data fopr the record
        txtOrderID.Text = order.ThisOrder.OrderID.ToString();
        txtPrice.Text = order.ThisOrder.Price.ToString();
        txtComments.Text = order.ThisOrder.Comments;
        txtItem.Text = order.ThisOrder.Item;
        txtOrderDate.Text = order.ThisOrder.OrderDate.ToString();
        chkDispatch.Checked = order.ThisOrder.Dispatch;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}

    
