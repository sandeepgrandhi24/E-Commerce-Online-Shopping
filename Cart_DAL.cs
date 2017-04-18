using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class Cart_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetAllCart(int LoginId)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Get_AllCart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
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

        public int CreateCart(Cart ObjCrt)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_SaveCart", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ItemOrder", ObjCrt.ItemOrderId);
                com.Parameters.AddWithValue("@Quantity", ObjCrt.Quantity);
                com.Parameters.AddWithValue("@Price", ObjCrt.Price);
                com.Parameters.AddWithValue("@LoginId", ObjCrt.CartId);
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
