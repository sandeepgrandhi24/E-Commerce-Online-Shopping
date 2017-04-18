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
   public class Credicards_DAL
    {
       string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;


       public int CreateCardsinfo(CraditCard ObjCrd)
       {
           using (SqlConnection con = new SqlConnection(connstring))
           {
               SqlCommand com = new SqlCommand("sp_SaveOrders", con);
               com.CommandType = CommandType.StoredProcedure;
               com.Parameters.AddWithValue("@OrderItemId", ObjCrd.OrderID);
               com.Parameters.AddWithValue("@OrderQuantity", ObjCrd.Qunt);
               com.Parameters.AddWithValue("@LoginId", ObjCrd.LoginID);
               com.Parameters.AddWithValue("@Type", ObjCrd.Type);
               com.Parameters.AddWithValue("@CcNumber", ObjCrd.CcNumber);
               com.Parameters.AddWithValue("@CName", ObjCrd.CName);
               com.Parameters.AddWithValue("@Cvv", ObjCrd.Cvv);
               com.Parameters.AddWithValue("@Exp", ObjCrd.Exp);
               com.Parameters.AddWithValue("@Street", ObjCrd.Street);
               com.Parameters.AddWithValue("@CityID", ObjCrd.CityID);
               com.Parameters.AddWithValue("@StateID", ObjCrd.StateID);
               com.Parameters.AddWithValue("@CountryID", ObjCrd.CountryID);
               com.Parameters.AddWithValue("@Zipcode", ObjCrd.Zipcode);

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
