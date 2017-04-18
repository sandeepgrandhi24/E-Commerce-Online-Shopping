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
    public partial class CategoriesItems : System.Web.UI.Page
    {
         Items_BAL ObjBal = new Items_BAL();
         protected void Page_Load(object sender, EventArgs e)
         {
             if (!IsPostBack)
             {
                if (Session["LoginID"] != null)
                {
                    string Id = Request.QueryString["Id"];
                    DataSet Ds = ObjBal.GetAllItems();

                    DataRow[] row = Ds.Tables[0].Select("CategoryID=" + Id);
                    if (row.Count() != 0)
                    {

                        ItemName.Text = row[0].ItemArray[2].ToString();

                        ItemDesc.Text = row[0].ItemArray[3].ToString();
                        Imgrl.ImageUrl = "Images/Items/" + row[0].ItemArray[4].ToString();
                        //Price.Text = row[0].ItemArray[11].ToString();
                        HyperLink1.NavigateUrl = "ItemsDisplay.aspx?id=" + row[0].ItemArray[0].ToString();
                        //
                      
                    }
                    if(row.Count() >1)
                    {
                        
                        //
                        ItemName2.Text = row[1].ItemArray[2].ToString();

                        ItemDesc2.Text = row[1].ItemArray[3].ToString();
                        Imgrl2.ImageUrl = "Images/Items/" + row[1].ItemArray[4].ToString();
                        //Price.Text = row[0].ItemArray[11].ToString();
                        HyperLink2.NavigateUrl = "ItemsDisplay.aspx?id=" + row[1].ItemArray[1].ToString();
                    }
                    //else
                    //    Msg.Text = "Selected category is not available.";
                }
            }
                else
                {
                    Response.Redirect("Login.aspx");
                }
             }
         }
    }
