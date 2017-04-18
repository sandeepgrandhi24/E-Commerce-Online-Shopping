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
    public partial class cmsInventories : System.Web.UI.Page
    {
        Inventories_BAL BalObj = new Inventories_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               //NewQuantity_.stStyle.Add("visibility", "hidden");
               //NewPrice_.Style.Add("visibility", "hidden");
                Gridview();
            }
        }

        public void Gridview()
        {
            DataSet Ds = BalObj.GetAllInventories();

            dataTables.DataSource = Ds;
            dataTables.DataBind();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            dataTables.PageIndex = e.NewPageIndex;
            dataTables.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //getting username from particular row
                string BrandName = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "BrandName"));
                LinkButton lnkbtnresult = (LinkButton)e.Row.FindControl("lnkdelete");
               // lnkbtnresult.Attributes.Add("onclick", "javascript:return ConfirmationBox('" + BrandName + "')");
            }
        }

        protected void Inventory_Click(object sender, EventArgs e)
        {
            LinkButton lnkEdit = sender as LinkButton;
           TextBox txtprice = sender as TextBox;
            GridViewRow gvrow = lnkEdit.NamingContainer as GridViewRow;
            
         
            int id = Convert.ToInt32(dataTables.DataKeys[gvrow.RowIndex].Value.ToString());
            if (NewQuantity_.Value  != "" && NewPrice_.Value != "")
            {
                int NewQuanti = Convert.ToInt32(NewQuantity_.Value);
                int NewPrice = Convert.ToInt32(NewPrice_.Value);

                int Status = BalObj.UpdateInventory(id, NewPrice, NewQuanti);
                if (Status.Equals(1))
                    TxtMsg.Text = "Selected item update success.";
                else
                    TxtMsg.Text = "While update item error. Please try agin.";
            }
            Gridview();
        }
    }
}