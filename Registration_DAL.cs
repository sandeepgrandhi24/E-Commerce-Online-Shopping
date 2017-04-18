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
   public class Registration_DAL
    {
        string connstring = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;





        public int CreateRegistration(Loginprofile LogObj)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand com = new SqlCommand("sp_SaveRegstration", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Firstname", LogObj.Firstname);
                com.Parameters.AddWithValue("@Lastname", LogObj.Lastname);
                com.Parameters.AddWithValue("@Birthdate", LogObj.Birthdate);
                com.Parameters.AddWithValue("@Hno", LogObj.Hno);
                com.Parameters.AddWithValue("@Street", LogObj.Street);
                com.Parameters.AddWithValue("@City", LogObj.City);
                com.Parameters.AddWithValue("@State", LogObj.State);
                com.Parameters.AddWithValue("@Country", LogObj.Country);
                com.Parameters.AddWithValue("@Pincode", LogObj.Pincode);
                com.Parameters.AddWithValue("@ContactNo", LogObj.ContactNo);
                com.Parameters.AddWithValue("@Email", LogObj.Email);
                com.Parameters.AddWithValue("@Loginname", LogObj.Loginname);
                com.Parameters.AddWithValue("@Password", LogObj.Password);
                com.Parameters.AddWithValue("@Squestionid", LogObj.Squestionid);
                com.Parameters.AddWithValue("@Sanswer", LogObj.Sanswer);

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
