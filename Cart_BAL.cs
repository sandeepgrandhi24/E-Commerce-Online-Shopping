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
    public class Cart_BAL
    {
        Cart_DAL DalObj = new Cart_DAL();
        public DataSet GetAllCart(int LoginId)
        {
            return DalObj.GetAllCart(LoginId);
        }

        public int CreateCart_(Cart crtObj)
        {
            return DalObj.CreateCart(crtObj);
        }


    }
}
