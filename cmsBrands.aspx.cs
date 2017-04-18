using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTO;
using BAL;

namespace OnlineShopping
{
    public partial class cmsBrands : System.Web.UI.Page
    {
        Brands_BAL ObjBnd = new Brands_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Gridview();
        }

        public void Gridview()
        {
            DataSet Brands = ObjBnd.GetAllBrand();

            dataTables.DataSource = Brands;
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
                lnkbtnresult.Attributes.Add("onclick", "javascript:return ConfirmationBox('" + BrandName + "')");
            }
        }

        protected void lnkdelete_Click(object sender, EventArgs e)
        {
            LinkButton lnkbtn = sender as LinkButton;
            GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;            
            int id = Convert.ToInt32(dataTables.DataKeys[gvrow.RowIndex].Value.ToString());
            int Status = ObjBnd.DeleteBrand(id);

            if (Status.Equals(1))
                TxtMsg.Text = "New brand delete success.";
            else
                TxtMsg.Text = "While creating delete error. Please try agin.";
            Gridview();
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            LinkButton lnkEdit = sender as LinkButton;
            GridViewRow gvrow = lnkEdit.NamingContainer as GridViewRow;
            int Brandid = Convert.ToInt32(dataTables.DataKeys[gvrow.RowIndex].Value.ToString());
            Response.Redirect("cmsBrandsEdit.aspx?Id=" + Brandid);
        }

      

    }
}