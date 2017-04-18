using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class Queries_BAL
    {
       Queries_DAL QObj = new Queries_DAL();
       public DataSet GetAllQueries()
       {
           return QObj.GetAllQueries();
       }

    }
}
