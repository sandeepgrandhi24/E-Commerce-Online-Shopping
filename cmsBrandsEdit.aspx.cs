using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DTO;
using System.Data;
using System.IO;

namespace OnlineShopping
{
    public partial class cmsBrandsEdit : System.Web.UI.Page
    {
        Brands_BAL Objbnd = new Brands_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Id = Request.QueryString["Id"];

                DataSet Brand = Objbnd.GetAllBrand();

                DataRow[] row = Brand.Tables[0].Select("BrandID=" + Id);

                BrandId.Value = row[0].ItemArray[0].ToString();
                BrandName.Text = row[0].ItemArray[1].ToString();
                BrandDesc.Text = row[0].ItemArray[2].ToString();
                BrandImgUrl.Value = row[0].ItemArray[4].ToString();
                Image1.ImageUrl = "Images/BrandLogos/" + row[0].ItemArray[4].ToString();
            }
        }

        protected void EditBrands_Click(object sender, EventArgs e)
        {
            Brand _ObjBnd = new Brand();
            _ObjBnd.BrandID = Convert.ToInt32(BrandId.Value);
            _ObjBnd.BrandName = BrandName.Text;
            _ObjBnd.BrandDesc = BrandDesc.Text;

            if (file.HasFile)
            {
                string fileName = Path.GetFileName(file.PostedFile.FileName);
                _ObjBnd.BrandImgUrl = fileName;
                file.PostedFile.SaveAs(Server.MapPath("~/Images/BrandLogos") + fileName);
            }
            else
            {
                _ObjBnd.BrandImgUrl = BrandImgUrl.Value;
            }

            int Status = Objbnd.CreateBrand(_ObjBnd);

            if (Status.Equals(1))
                TxtMsg.Text = "New brand update success.";
            else
                TxtMsg.Text = "While update brand error. Please try agin.";



        }
    }
}