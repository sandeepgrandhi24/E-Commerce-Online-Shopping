using BAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShopping
{
    public partial class cmsCategoriesCreate : System.Web.UI.Page
    {
        Category ObjCate = new Category();
        Categories_BAL CateObj = new Categories_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region add Category
        protected void CreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                ObjCate.CategoryName = CategoryName.Text;
                ObjCate.CategoryDesc = CategoryDesc.Text;

                string Filepath = string.Empty;

                if (file.HasFile)
                {
                    string fileName = Path.GetFileName(file.PostedFile.FileName);
                    ObjCate.CategoryImgUrl = fileName;
                    file.PostedFile.SaveAs(Server.MapPath("~/Images/CategoryLogos/") + fileName);
                }

                int Status = CateObj.CreateCategory(ObjCate);

                if (Status.Equals(1))
                    TxtMsg.Text = "New Category created success.";
                else
                    TxtMsg.Text = "While creating Category error. Please try agin.";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}