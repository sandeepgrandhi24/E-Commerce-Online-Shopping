using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    
   public class Registration_BAL
   {
       Registration_DAL regObj = new Registration_DAL();

       public int CreateRegistration(Loginprofile LogObj)
       {
           return regObj.CreateRegistration(LogObj);
       }
    }
}
