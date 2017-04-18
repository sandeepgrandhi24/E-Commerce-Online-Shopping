using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShopping
{
    public partial class Cart : System.Web.UI.Page
    {
        Cart_BAL BalObj = new Cart_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] != null)
            {
                int LoginId = Convert.ToInt32(Session["LoginID"].ToString());
                Gridview(LoginId);
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

        public void Gridview(int LoginId)
        {
            DataSet Ds = BalObj.GetAllCart(LoginId);

            dataTables.DataSource = Ds;
            dataTables.DataBind();
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton lnkEdit = sender as LinkButton;

            GridViewRow gvrow = lnkEdit.NamingContainer as GridViewRow;
            int Brandid = Convert.ToInt32(dataTables.DataKeys[gvrow.RowIndex].Value.ToString());
            Response.Redirect("ItemsDisplay.aspx?Id=" + Brandid);
        }

    }
}