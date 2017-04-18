using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BAL
{
   public class Categories_BAL
    {
       Categories_DAL DalObj = new Categories_DAL();


       public DataSet GetAllCategories()
       {
         return  DalObj.GetAllCategories();
       }
       public int CreateCategory(Category ObjCate)
       {
           return DalObj.CreateCategory(ObjCate); 
       }

       public int DeleteCategory(int Id)
       {
           return DalObj.DeleteCategory(Id);
       }
       
    }
}
