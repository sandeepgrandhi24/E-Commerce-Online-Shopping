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
    public partial class cmsCategoriesEdit : System.Web.UI.Page
    {
        Categories_BAL ObjCate = new Categories_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Id = Request.QueryString["Id"];

                DataSet Categ = ObjCate.GetAllCategories();

                DataRow[] row = Categ.Tables[0].Select("CategoryID=" + Id);

                CategoryId.Value = row[0].ItemArray[0].ToString();
                CategoryName.Text = row[0].ItemArray[1].ToString();
                CategoryDesc.Text = row[0].ItemArray[2].ToString();
                CategoryImgUrl.Value = row[0].ItemArray[3].ToString();
                Image1.ImageUrl = "~/Images/CategoryLogos/" + row[0].ItemArray[3].ToString();
            }
        }
        
        protected void EditCategory_Click(object sender, EventArgs e)
        {
            Category _ObjCate = new Category();
            _ObjCate.CategoryID = Convert.ToInt32(CategoryId.Value);
            _ObjCate.CategoryName = CategoryName.Text;
            _ObjCate.CategoryDesc = CategoryDesc.Text;

            if (file.HasFile)
            {
                string fileName = Path.GetFileName(file.PostedFile.FileName);
                _ObjCate.CategoryImgUrl = fileName;
                file.PostedFile.SaveAs(Server.MapPath("~/Images/CategoryLogos/") + fileName);
            }
            else
            {
                _ObjCate.CategoryImgUrl = CategoryImgUrl.Value;
            }

            int Status = ObjCate.CreateCategory(_ObjCate);

            if (Status.Equals(1))
                TxtMsg.Text = "Category update success.";
            else
                TxtMsg.Text = "While update category error. Please try agin.";



        }
    }
}