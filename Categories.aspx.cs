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
    public partial class Categories : System.Web.UI.Page
    {
        Categories_BAL ObjBal = new Categories_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] != null)
            {
                grid();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        public void grid()
        {
            DataSet Brands = ObjBal.GetAllCategories();
            Repeater1.DataSource = Brands;
            Repeater1.DataBind();

        }
    }
}