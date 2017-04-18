using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BAL
{
  public  class Brands_BAL
    {
      Brand Objbnd = new Brand();
      
      Brand_DAL BndObj = new Brand_DAL();

      public DataSet GetAllBrand()
      {
          return BndObj.GetAllBrand();
      }

      public int CreateBrand(Brand Objbnd_)
      {
          return BndObj.CreateBrand(Objbnd_);
      }

      public int DeleteBrand(int Id)
      {
          return BndObj.DeleteBrand(Id);
      }




    }
}
