using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Items_DAL
    {

        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetAllItems()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Get_Items", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet Ds = new DataSet();
                    da.Fill(Ds);
                    return Ds;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int CreateItems(Item ObjItem)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_SaveItems", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@BrandId", ObjItem.BrandID);
                com.Parameters.AddWithValue("@CategoryId", ObjItem.CategoryID);
                com.Parameters.AddWithValue("@ItemName", ObjItem.ItemName);
                com.Parameters.AddWithValue("@ItemDesc", ObjItem.ItemDesc);
                com.Parameters.AddWithValue("@ItemOffer", ObjItem.ItemOffer);
                com.Parameters.AddWithValue("@ItemImageURL", ObjItem.ImageURL);
                com.Parameters.AddWithValue("@ItemPrice", ObjItem.Price);
                com.Parameters.AddWithValue("@ItemQuantity", ObjItem.Quantity);
                com.Parameters.AddWithValue("@ItemsId", ObjItem.ItemID);
                com.Parameters.AddWithValue("@CreatedBy", 0);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }

        public int DeleteItems(int Id)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_ItemDelete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ItemId", Id);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
