using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DTO;

namespace DAL
{
    public class Categories_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetAllCategories()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Categories", con);
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

        public int CreateCategory(Category ObjCate)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_SaveCategory", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CategoryID", ObjCate.CategoryID);
                com.Parameters.AddWithValue("@CategoryName", ObjCate.CategoryName);
                com.Parameters.AddWithValue("@CategoryDesc", ObjCate.CategoryDesc);
                com.Parameters.AddWithValue("@CategoryImgUrl", ObjCate.CategoryImgUrl);
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

        public int DeleteCategory(int Id)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_CategoryDelete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CategoryId", Id);

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
