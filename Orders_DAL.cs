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
    public class Orders_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetAllOrders(int LoginId)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Get_AllOrders", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LoginID", LoginId);
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



        public int DeleteOrder(int Id)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("Sp_DeleteOrder", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@OrderID", Id);

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
