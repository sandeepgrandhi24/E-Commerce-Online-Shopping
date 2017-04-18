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
   public class Brand_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetAllBrand()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetBrands", con);
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

        public int CreateBrand(Brand Objbnd)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_SaveBrands", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@BrandID", Objbnd.BrandID);
                com.Parameters.AddWithValue("@BrandName", Objbnd.BrandName);
                com.Parameters.AddWithValue("@BrandDesc", Objbnd.BrandDesc);
                com.Parameters.AddWithValue("@BrandImgUrl", Objbnd.BrandImgUrl);
                com.Parameters.AddWithValue("@CreatedBy", "Admin");

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
               
        public int DeleteBrand(int Id)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_BrandDelete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@BrandId", Id);

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
