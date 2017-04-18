
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineShopping
{
    public partial class Brands : System.Web.UI.Page
    {
        Brands_BAL ObjBal = new Brands_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] != null)
            {
                DataSet Brands = ObjBal.GetAllBrand();
                Repeater1.DataSource = Brands;
                Repeater1.DataBind();
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

       
       
    }
}