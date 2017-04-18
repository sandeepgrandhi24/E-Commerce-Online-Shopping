using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DTO;
using System.IO;
using BAL;
using DTO;
using System.Data;
namespace OnlineShopping
{
    public partial class cmsBrandsCreate : System.Web.UI.Page
    {
        Brand Objbnd = new Brand();
        Brands_BAL BndObj = new Brands_BAL();
        Brand bs = new Brand();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadDDL();
            //}
        }

        #region add brand
        protected void CreateBrand_Click(object sender, EventArgs e)
        {
            try
            {
                Objbnd.BrandName = BrandName.Text;
                Objbnd.BrandDesc = BrandDesc.Text;
              //  bs.CategoryID = Convert.ToInt32(categorylist.SelectedValue);
                // = Convert.ToInt32(DDLBrand.SelectedValue);
                string Filepath = string.Empty;

                if (file.HasFile)
                {
                    string fileName = Path.GetFileName(file.PostedFile.FileName);
                    Objbnd.BrandImgUrl = fileName;
                    file.PostedFile.SaveAs(Server.MapPath("~/Images/BrandLogos") + fileName);                   
                }

                int Status = BndObj.CreateBrand(Objbnd);

                if (Status.Equals(1))
                    TxtMsg.Text = "New brand created success.";
                else
                    TxtMsg.Text = "While creating brand error. Please try agin.";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        //public void LoadDDL()
        //{
        //    Brands_BAL Bnds = new Brands_BAL();
        //    Categories_BAL cate = new Categories_BAL();
        //    DataSet ds = Bnds.GetAllBrand();
        //    DataSet dsCate = cate.GetAllCategories();

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        categorylist.DataSource = ds;
        //        categorylist.DataTextField = "CategoryName";
        //        categorylist.DataValueField = "CategoryID";
        //        //Dispose the Dataset first.

        //        categorylist.DataBind();
        //        ds.Dispose();
               
        //    }
        //}


        }
}