using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace OnlineShopping
{
    public partial class BrandItems : System.Web.UI.Page
    {
        Categories_BAL ObjBal = new Categories_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginID"] != null)
                {
                    string Id = Request.QueryString["Id"];
                    DataSet Ds = ObjBal.GetAllCategories();
                    Repeater1.DataSource = Ds;
                    Repeater1.DataBind();

                    //DataRow[] row = Ds.Tables[0].Select("CategoryID=" + Id);

                    //if (row.Count() != 0)
                    //{
                    //    ItemName.Text = row[0].ItemArray[1].ToString();
                    //    ItemDesc.Text = row[0].ItemArray[2].ToString();
                    //    Imgrl.ImageUrl = "Images/CategoryLogos/" + row[0].ItemArray[9].ToString();
                    //    //Price.Text = row[0].ItemArray[11].ToString();
                    //    HyperLink1.NavigateUrl = "ItemsDisplay.aspx?id=" + row[0].ItemArray[0].ToString();
                    //    // }
                    //}

                }
                else {
                    
                    Response.Redirect("Login.aspx");
                }
            }
        }

    }
}