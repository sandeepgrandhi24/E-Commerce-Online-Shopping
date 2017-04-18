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
    public partial class cmsFeedBack : System.Web.UI.Page
    {
        FeedBack_BAL FeedBackObj = new FeedBack_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginID"] != null)
            {
                Gridview();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        public void Gridview()
        {
            DataSet Ds = FeedBackObj.GetAllFeedBack();

            dataTables.DataSource = Ds;
            dataTables.DataBind();
        }
    }
}