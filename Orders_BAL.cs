using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class Orders_BAL
    {
       Orders_DAL OrdrsDal = new Orders_DAL();
       public DataSet GetAllOrders(int LoginID)
       {
           return OrdrsDal.GetAllOrders(LoginID);
       }

       public int DeleteOrder(int Id)
       {
           return OrdrsDal.DeleteOrder(Id); 
       }
    }
}
