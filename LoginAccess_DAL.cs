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
   public class LoginAccess_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

        public DataSet GetUserLoginInfo(Loginprofile LogObj)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Get_LoginInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LoginName", LogObj.Loginname);
                    cmd.Parameters.AddWithValue("@Password", LogObj.Password);
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

           
        

       
    }
}
