using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BAL
{
    public class Items_BAL
    {
        Item ObjItem = new Item();
        Items_DAL ItemObj = new Items_DAL();
        Cart_DAL DalObj = new Cart_DAL();

        public DataSet GetAllItems()
        {
            return ItemObj.GetAllItems();
        }

        public int CreateItems(Item ObjItem)
        {
            return ItemObj.CreateItems(ObjItem);
        }

        public int DeleteItems(int ItemId)
        {
            return ItemObj.DeleteItems(ItemId);
        }

        public int CreateCart(Cart ObjCrt)
        {
            return DalObj.CreateCart(ObjCrt);
        }

    }
}
