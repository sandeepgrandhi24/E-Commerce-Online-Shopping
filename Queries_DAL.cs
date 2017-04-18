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
   public class Queries_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
        public DataSet GetAllQueries()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Queries", con);
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
    }
}
