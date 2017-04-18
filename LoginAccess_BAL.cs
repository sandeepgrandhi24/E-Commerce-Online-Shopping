using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
  public class LoginAccess_BAL
    {
      LoginAccess_DAL LogObj_ = new LoginAccess_DAL();
      public DataSet GetUserLoginInfo(Loginprofile LogObj)
      {
          return LogObj_.GetUserLoginInfo(LogObj);
      }
    }
}
