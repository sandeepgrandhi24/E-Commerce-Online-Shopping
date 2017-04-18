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
   public class FeedBack_DAL
    {
       string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
       public DataSet GetAllFeedBack()
       {
           using (SqlConnection con = new SqlConnection(connstring))
           {
               try
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand("sp_Get_AllFeedback", con);
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

       public DataSet GetFeedBackDDL()
       {
           using (SqlConnection con = new SqlConnection(connstring))
           {
               try
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand("sp_Get_FeedBackDDL", con);
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

       public int CreateFeedBack(Feedback Objfbk)
       {
           using (SqlConnection con = new SqlConnection(connstring))
           {
               SqlCommand com = new SqlCommand("sp_SaveFeedback", con);
               com.CommandType = CommandType.StoredProcedure;
               com.Parameters.AddWithValue("@LoginId", Objfbk.LoginID);
               com.Parameters.AddWithValue("@BrandId", Objfbk.Brandid);
               com.Parameters.AddWithValue("@CategoryId", Objfbk.Categoryid);
               com.Parameters.AddWithValue("@ItemId", Objfbk.Itemid);
               com.Parameters.AddWithValue("@FeedbackDec", Objfbk.Feedbackdesc1);

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
