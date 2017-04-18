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
    
   public class FeedBack_BAL
    {
       FeedBack_DAL FeedbObj = new FeedBack_DAL();
       public DataSet GetAllFeedBack()
       {
           return FeedbObj.GetAllFeedBack();
       }

       public DataSet GetFeedBackDDL()
       {
           return FeedbObj.GetFeedBackDDL();
       }

       public int CreateFeedBack(Feedback Objfbk)
       {
           return FeedbObj.CreateFeedBack(Objfbk);
       }
    }
}
