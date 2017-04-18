using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class Inventories_BAL
    {
       Inventories_DAL DalObj = new Inventories_DAL();

       public DataSet GetAllInventories()
       {
           return DalObj.GetAllInventories();
       }
       public int UpdateInventory(int ItemId, int Price, int Quantity)
       {
           return DalObj.UpdateInventory(ItemId, Price, Quantity);
       }

    }
}
