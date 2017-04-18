using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
  public class Credicards_BAL
    {
      Credicards_DAL CrdObj = new Credicards_DAL();
      public int CreateCraditApp(CraditCard Obj)
      {
          return CrdObj.CreateCardsinfo(Obj);
      }
    }
}
