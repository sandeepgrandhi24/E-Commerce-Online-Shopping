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
   public class Inventories_DAL
    {
       string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
       public DataSet GetAllInventories()
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

       public int UpdateInventory(int ItemId,int Price,int Quantity)
       {
           using (SqlConnection con = new SqlConnection(connstring))
           {
               SqlCommand com = new SqlCommand("sp_UpdateInventory", con);
               com.CommandType = CommandType.StoredProcedure;
               com.Parameters.AddWithValue("@ItemId", ItemId);
               com.Parameters.AddWithValue("@Price", Price);
               com.Parameters.AddWithValue("@Quantity", Quantity);

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
