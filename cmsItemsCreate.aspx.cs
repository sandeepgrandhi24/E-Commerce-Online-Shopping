using BAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShopping
{
    public partial class cmsItemsCreate : System.Web.UI.Page
    {
        Item ObjItem = new Item();
        Items_BAL ItemObj = new Items_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDDL();
            }
        }

        #region add Items
        protected void CreateItem_Click(object sender, EventArgs e)
        {
            try
            {
                ObjItem.ItemName = ItemName.Text;
                ObjItem.ItemDesc = ItemDesc.Text;
                ObjItem.ItemOffer = ItemOffer.Text; 
                ObjItem.Quantity =Convert.ToInt32(ItemQuantity.Text);
                ObjItem.Price = Convert.ToInt32(ItemPrice.Text);
                ObjItem.BrandID = Convert.ToInt32(DDLBrand.SelectedValue);
                ObjItem.CategoryID = Convert.ToInt32(DDLCategory.SelectedValue);
                string Filepath = string.Empty;

                if (file.HasFile)
                {
                    string fileName = Path.GetFileName(file.PostedFile.FileName);
                    ObjItem.ImageURL = fileName;
                    file.PostedFile.SaveAs(Server.MapPath("~/Images/Items/") + fileName);
                }

                int Status = ItemObj.CreateItems(ObjItem);

                if (Status.Equals(1))
                    TxtMsg.Text = "New Item created success.";
                else
                    TxtMsg.Text = "While creating Item error. Please try agin.";

                LoadDDL(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        public void LoadDDL()
        {
            Brands_BAL Bnds = new Brands_BAL();
            Categories_BAL cate = new Categories_BAL();
            DataSet ds = Bnds.GetAllBrand();
            DataSet dsCate=cate.GetAllCategories();

            if (ds.Tables[0].Rows.Count > 0)
            {
                //Dispose the Dataset first.
                ds.Dispose();
                DDLBrand.Items.Clear();
                DDLBrand.DataSource = ds;
                DDLBrand.DataTextField = "BrandName";
                DDLBrand.DataValueField = "BrandID";
                DDLBrand.DataBind();
                DDLBrand.Items.Insert(0, new ListItem("-- Select any brand --", "0"));
            }
          if (dsCate.Tables[0].Rows.Count > 0)
            {
                //Dispose the Dataset first.
                ds.Dispose();
                DDLCategory.Items.Clear();
                DDLCategory.DataSource = dsCate;
                DDLCategory.DataTextField = "CategoryName";
                DDLCategory.DataValueField = "CategoryID";
                DDLCategory.DataBind();
                DDLCategory.Items.Insert(0, new ListItem("-- Select any category --", "0"));
            }


        }
    }
}